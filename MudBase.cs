using ff14bot;
using ff14bot.AClasses;
using ff14bot.Behavior;
using ff14bot.Enums;
using ff14bot.Managers;
using ff14bot.Navigation;
using ff14bot.Objects;
using ff14bot.RemoteWindows;
using Mud.Helpers;
using Mud.Properties;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Input;
using TreeSharp;

namespace Mud
{
    public class MudBase : BotBase
    {
        public static String LastTargetName = null;
        public const  String Version        = "2.0.4";

        #region Selectable Values

        public static String[] ModifierKeyStrings = { "None", "Shift", "Control", "Alt" };
        public static String[] TargetingModes = { "None", "Assist Tank", "Being Tanked", "Nearest Enemy" };
        public static String[] TargetListTypes = { "None", "Whitelist", "Blacklist" };
        public static String[] MovementModes = { "Combat", "Tank", "Follow" };
        public static String[] SupportedNavigationProviders = { "Null", "Gaia" };

        #endregion Selectable Values

        #region BotBase

        public bool TreeTick()
        {
            if (Core.Player.CurrentTarget != null && Core.Player.CurrentTarget.Name != null)
                LastTargetName = Core.Player.CurrentTarget.Name;
            WaypointManager.Track();
            SettingsForm.UpdateStatus();
            return true;
        }

        public static void UpdateNavigationProvider()
        {
            //Logging.Write(LogLevel.PRIMARY, "Updating Navigation Provider to: {0}", MudBase.SupportedNavigationProviders[Properties.Settings.Default.SELECTED_NAVIGATION_PROVIDER]);
            switch (MudBase.SupportedNavigationProviders[Properties.Settings.Default.SELECTED_NAVIGATION_PROVIDER])
            {
                case "Null":
                    if (!(Navigator.NavigationProvider is NullProvider))
                    {
                        GaiaNavigator g = (Navigator.NavigationProvider as GaiaNavigator);
                        if (g != null) g.Dispose();
                        Navigator.NavigationProvider = new NullProvider();
                        Logging.Write(LogLevel.PRIMARY, "Using Null Navigator");
                    }
                    break;
                case "Gaia":
                    if (!(Navigator.NavigationProvider is GaiaNavigator))
                    {
                        Navigator.NavigationProvider = new GaiaNavigator();
                        Logging.Write(LogLevel.PRIMARY, "Using Gaia Navigator");
                    }
                    break;
                default:
                    break;
            }
        }

        #endregion BotBase

        #region Overrides

        public override string Name { get { return "Mud Assist"; } }
        public override bool WantButton { get { return true; } }
        public override bool RequiresProfile { get { return false; } }
        public override PulseFlags PulseFlags { get { return PulseFlags.All; } }

        public override void OnButtonPress()
        {
            Logging.Write(LogLevel.INFO, "Opening Settings");
            SettingsForm _Settings = new SettingsForm();
            _Settings.ShowDialog();
        }

        public override void Initialize()
        {
            Logging.Write(LogLevel.PRIMARY, "Initializing Mud Assist v{0}",Version);
            MudBase.ResetHotkeys();
        }

        public override void Start()
        {
            MudBase.UpdateNavigationProvider();
            Navigator.PlayerMover = new SlideMover();
            Logging.Write(LogLevel.PRIMARY, "Started");
            MudBase.ResetHotkeys();
        }

        public override void Stop()
        {
            _Root = null;
            Navigator.PlayerMover = new NullMover();
            GaiaNavigator g = (Navigator.NavigationProvider as GaiaNavigator);
            if (g != null) g.Dispose();
            Navigator.NavigationProvider = new NullProvider();
            Logging.Write(LogLevel.PRIMARY, "Stopped!");
            MudBase.UnregisterAllHotkeys();
        }

        private Composite _Root;
        public override Composite Root
        {
            get
            {
                return _Root ?? (_Root =
                    new Decorator(
                        req => TreeTick()
                            && !Settings.Default.COMBAT_ROUTINE_PAUSED
                            && Core.Player.IsAlive
                            && !Core.Player.IsCasting
                            && (!MovementManager.IsMoving
                                || Settings.Default.COMBAT_ROUTINE_EXECUTE_WHILE_MOVING),
                        new PrioritySelector(
                    // Questing Stuff
                    //new Decorator(
                    //    req => Settings.Default.AUTO_SKIP_CUTSCENES
                    //        && QuestLogManager.InCutscene,
                    //    new TreeSharp.Action(a => { 
                    //        SendKeys.SendWait(Keys.Escape.ToString());
                    //        if (SelectYesno.IsOpen)
                    //            SelectYesno.ClickYes();
                    //    })),
                            new Decorator(
                                req => Settings.Default.AUTO_TALK_NPCS
                                    && Talk.DialogOpen,
                                new TreeSharp.Action(a => { Talk.Next(); })),
                            new Decorator(
                                req => Settings.Default.AUTO_ACCEPT_QUESTS
                                    && JournalAccept.IsOpen,
                                new TreeSharp.Action(a => { JournalAccept.Accept(); })),
                    // Auto-Sprint
                            new Decorator(
                                req => Settings.Default.AUTO_SPRINT
                                    && !IsValidEnemy(Core.Player.CurrentTarget)
                                    && !Core.Player.InCombat
                                    && Actionmanager.IsSprintReady
                                    && MovementManager.IsMoving
                                    && !DutyManager.InInstance
                                    && !Core.Player.IsMounted,
                                new TreeSharp.Action(a => { Actionmanager.Sprint(); })),
                    // Resting
                            new Decorator(
                                req => RoutineManager.Current.RestBehavior != null
                                    && !Core.Player.InCombat
                                    && Settings.Default.COMBAT_ROUTINE_REST
                                    && !Core.Player.IsMounted
                                    && Actionmanager.IsSprintReady,
                                RoutineManager.Current.RestBehavior),
                    // Out Of Combat Healing
                            new Decorator(
                                req => RoutineManager.Current.HealBehavior != null
                                    && (Core.Player.InCombat
                                        || Settings.Default.COMBAT_ROUTINE_HEAL_OUT_OF_COMBAT)
                                    && Settings.Default.COMBAT_ROUTINE_HEAL
                                    && !Core.Player.IsMounted,
                                RoutineManager.Current.HealBehavior),
                    // Pre-Combat Buffs
                            new Decorator(
                                req => RoutineManager.Current.PreCombatBuffBehavior != null
                                    && !Core.Player.InCombat
                                    && Settings.Default.COMBAT_ROUTINE_PRECOMBATBUFF
                                    && !Core.Player.IsMounted,
                                RoutineManager.Current.PreCombatBuffBehavior),
                    // Stop Moving If Moving & In Range Of Target
                            new Decorator(
                                req => Settings.Default.AUTO_MOVE
                                    //&& MovementManager.IsMoving
                                    && WaypointManager.IsNavigating
                                    && WaypointManager.Next == null,
                                new TreeSharp.Action(a => { WaypointManager.StopNavigating(); })),
                    // Move To Target If Not In Range & Not On The Move
                            new Decorator(
                                req => Settings.Default.AUTO_MOVE
                                    && !Core.Player.IsCasting
                                    && WaypointManager.Next != null,
                                new TreeSharp.Action(a =>
                                {
                                    WaypointManager.MoveToNext();
                                })),
                    // Find Suitable Target -- Lowest HP Tanked
                            new Decorator(
                                req => (PartyManager.IsInParty
                                    && TargetingModes[Settings.Default.SELECTED_TARGETING_MODE].Equals("Being Tanked")
                                    && VisiblePartyMembers.Where(pm => IsTank(pm)).Count() > 0
                                    && (!Core.Player.HasTarget
                                        || !Core.Player.CurrentTarget.CanAttack)),
                                new TreeSharp.Action(a =>
                                {
                                    IEnumerable<GameObject> objs = GameObjectManager.GameObjects.Where(o => IsValidEnemy(o)
                                        && (o as Character).InCombat
                                        && (o as Character).CurrentTargetId == PartyTank.ObjectId);
                                    if (objs != null && objs.Count() > 0)
                                    {
                                        objs.OrderBy(o => o.CurrentHealthPercent).First().Target();
                                    }
                                })),
                    // Find Suitable Target -- Assist Tank
                            new Decorator(
                                req => (PartyManager.IsInParty
                                    && TargetingModes[Settings.Default.SELECTED_TARGETING_MODE].Equals("Assist Tank")
                                    && VisiblePartyMembers.Where(pm => IsTank(pm)).Count() > 0
                                    && (!Core.Player.HasTarget
                                        || !Core.Player.CurrentTarget.CanAttack)),
                                new TreeSharp.Action(a => Assist(VisiblePartyMembers.Where(pm => IsTank(pm)).First()))),
                    // Find Suitable Target -- Nearest Enemy
                            new Decorator(
                                req => TargetingModes[Settings.Default.SELECTED_TARGETING_MODE].Equals("Nearest Enemy")
                                    && !Core.Player.HasTarget,
                                new TreeSharp.Action(a =>
                                {
                                    GameObject target = GetClosestEnemyByName(Settings.Default.MOBS_TO_TARGET);
                                    if (target != null)
                                        target.Target();
                                })),
                    // Pull Buff Behavior
                            new Decorator(
                                req => RoutineManager.Current.PullBuffBehavior != null
                                    && !Core.Player.InCombat
                                    && IsValidEnemy(Core.Player.CurrentTarget)
                                    && Settings.Default.COMBAT_ROUTINE_PULL_BUFF
                                    && !PartyManager.IsInParty,
                                RoutineManager.Current.PullBuffBehavior),
                    // Pull Behavior
                            new Decorator(
                                req => !Core.Player.InCombat
                                    && IsValidEnemy(Core.Player.CurrentTarget)
                                    && Settings.Default.COMBAT_ROUTINE_PULL
                                    && (!PartyManager.IsInParty || IsTank(Core.Player))
                                    && Core.Player.CurrentTarget.Location.Distance3D(Core.Player.Location) <= (RoutineManager.Current.PullRange + Core.Player.CurrentTarget.CombatReach + (float)Settings.Default.AUTO_MOVE_TARGET_RANGE),
                                new PrioritySelector(
                                    RoutineManager.Current.PullBehavior,
                                    RoutineManager.Current.CombatBehavior)),
                    // Executed In Combat
                            new Decorator(
                                req => !Core.Player.IsMounted
                                    && MudBase.InCombat,
                                new PrioritySelector(
                    // Combat Buffs
                                    new Decorator(
                                        req => RoutineManager.Current.CombatBuffBehavior != null
                                            && Settings.Default.COMBAT_ROUTINE_COMBATBUFF
                                             && !Core.Player.IsMounted,
                                        RoutineManager.Current.CombatBuffBehavior),
                    // Combat Routine
                                    new Decorator(
                                        req => RoutineManager.Current.CombatBehavior != null
                                            && Settings.Default.COMBAT_ROUTINE_COMBAT
                                            && !Core.Player.IsMounted
                                            && IsValidEnemy(Core.Player.CurrentTarget)
                                            && Core.Player.CurrentTarget.Location.Distance3D(Core.Player.Location) <= (RoutineManager.Current.PullRange + Core.Player.CurrentTarget.CombatReach + (float)Settings.Default.AUTO_MOVE_TARGET_RANGE),
                                        RoutineManager.Current.CombatBehavior))))));
            }
        }

        #endregion Overrides

        #region Hotkeys

        private static Hotkey _hotkeyPause;
        private static Hotkey _hotkeyTargetMode;
        private static Hotkey _hotkeyToggleMovement;
        private static Hotkey _hotkeyAddTargetTargetList;
        private static Hotkey _hotkeyAddRemTargetTargetList;
        private static Hotkey _hotkeyToggleMovementMode;
        public static void ResetHotkeys()
        {
            UnregisterAllHotkeys();
            // Hotkey To Pause / Unpause
            Keys key;
            CultureInfo cinfo = Thread.CurrentThread.CurrentCulture;
            TextInfo text = cinfo.TextInfo;
            try {key = (Keys)(new KeysConverter()).ConvertFromString(text.ToTitleCase(Settings.Default.HOTKEY_PAUSE));}
                catch (Exception e) {key = Keys.None;}
            if (key != Keys.None) {
                _hotkeyPause = HotkeyManager.Register(
                    "HK_MUD_PAUSE", 
                    key, 
                    (ModifierKeys)Enum.Parse(typeof(ModifierKeys), 
                    ModifierKeyStrings[Settings.Default.HOTKEY_MODIFIER_PAUSE]), 
                    hkPause => {
                        Settings.Default.COMBAT_ROUTINE_PAUSED = !Settings.Default.COMBAT_ROUTINE_PAUSED;
                        if (Settings.Default.COMBAT_ROUTINE_PAUSED) {
                            Logging.Write(LogLevel.PRIMARY, "Paused");
                            if (Settings.Default.UI_FLASH_MESSAGES)
                                FlashMessage.Flash(LogLevel.DANGER, "Paused"); 
                        } else {
                            Logging.Write(LogLevel.PRIMARY, "Unpaused");
                            if(Settings.Default.UI_FLASH_MESSAGES)
                                FlashMessage.Flash(LogLevel.SUCCESS, "Unpaused"); 
                        }});
                Logging.Write(LogLevel.INFO, "Added Hotkey: " + _hotkeyPause.ToString()); }

            // Hotkey To Change Targeting Mode
            try { key = (Keys)(new KeysConverter()).ConvertFromString(text.ToTitleCase(Settings.Default.HOTKEY_TARGET_MODE)); }
                catch (Exception e) { key = Keys.None; }
            if (key != Keys.None) {
                _hotkeyTargetMode = HotkeyManager.Register(
                    "HK_MUD_TARGET", 
                    key, 
                    (ModifierKeys)Enum.Parse(typeof(ModifierKeys), 
                    ModifierKeyStrings[Settings.Default.HOTKEY_MODIFIER_TARGET_MODE]), 
                    hkTargetMode => {
                        //Logging.Write(LogLevel.PRIMARY, "Previous Targeting Mode: " + TargetingModes[Settings.Default.SELECTED_TARGETING_MODE]);
                        if ((Settings.Default.SELECTED_TARGETING_MODE+1) == TargetingModes.Length)
                            Settings.Default.SELECTED_TARGETING_MODE = 0;
                        else
                            Settings.Default.SELECTED_TARGETING_MODE = (Settings.Default.SELECTED_TARGETING_MODE + 1);
                        SettingsForm.SelectTargetingMode(Settings.Default.SELECTED_TARGETING_MODE);
                        Logging.Write(LogLevel.PRIMARY, "Target Mode: " + TargetingModes[Settings.Default.SELECTED_TARGETING_MODE]);
                        if (Settings.Default.UI_FLASH_MESSAGES)
                            FlashMessage.Flash(LogLevel.WARNING, "Target: " + TargetingModes[Settings.Default.SELECTED_TARGETING_MODE]); 
                        });
                Logging.Write(LogLevel.INFO, "Added Hotkey: " + _hotkeyTargetMode.ToString());
            }

            // Hotkey To Toggle Movement
            try { key = (Keys)(new KeysConverter()).ConvertFromString(text.ToTitleCase(Settings.Default.HOTKEY_TOGGLE_MOVEMENT)); }
            catch (Exception e) { key = Keys.None; }
            if (key != Keys.None)
            {
                _hotkeyToggleMovement = HotkeyManager.Register(
                    "HK_MUD_TOGGLE_MOVEMENT",
                    key,
                    (ModifierKeys)Enum.Parse(typeof(ModifierKeys),
                    ModifierKeyStrings[Settings.Default.HOTKEY_MODIFIER_TOGGLE_MOVEMENT]),
                    hkToggleMovement =>
                    {
                        Settings.Default.AUTO_MOVE = !Settings.Default.AUTO_MOVE;
                        WaypointManager.StopNavigating();
                        if (Settings.Default.AUTO_MOVE)
                        {
                            Logging.Write(LogLevel.PRIMARY, "Movement ON");
                            if (Settings.Default.UI_FLASH_MESSAGES)
                                FlashMessage.Flash(LogLevel.PRIMARY, "Movement ON");
                        }
                        else
                        {
                            Logging.Write(LogLevel.DANGER, "Movement OFF");
                            if (Settings.Default.UI_FLASH_MESSAGES)
                                FlashMessage.Flash(LogLevel.WARNING, "Movement OFF");
                        }
                    });
                Logging.Write(LogLevel.INFO, "Added Hotkey: " + _hotkeyToggleMovement.ToString());
            }

            // Hotkey To Toggle Movement
            try { key = (Keys)(new KeysConverter()).ConvertFromString(text.ToTitleCase(Settings.Default.HOTKEY_MOVEMENT_MODE)); }
            catch (Exception e) { key = Keys.None; }
            if (key != Keys.None)
            {
                _hotkeyToggleMovement = HotkeyManager.Register(
                    "HK_MUD_TOGGLE_MOVEMENT_MODE",
                    key,
                    (ModifierKeys)Enum.Parse(typeof(ModifierKeys),
                    ModifierKeyStrings[Settings.Default.HOTKEY_MODIFIER_MOVEMENT_MODE]),
                    hkToggleMovementMode =>
                    {
                        //Logging.Write(LogLevel.PRIMARY, "Previous Targeting Mode: " + TargetingModes[Settings.Default.SELECTED_TARGETING_MODE]);
                        if ((Settings.Default.SELECTED_MOVEMENT_MODE + 1) == MudBase.MovementModes.Length)
                            Settings.Default.SELECTED_MOVEMENT_MODE = 0;
                        else
                            Settings.Default.SELECTED_MOVEMENT_MODE = (Settings.Default.SELECTED_MOVEMENT_MODE + 1);
                        SettingsForm.SelectMovementMode(Settings.Default.SELECTED_MOVEMENT_MODE);
                        Logging.Write(LogLevel.PRIMARY, "Move Mode: " + MovementModes[Settings.Default.SELECTED_MOVEMENT_MODE]);
                        if (Settings.Default.UI_FLASH_MESSAGES)
                            FlashMessage.Flash(LogLevel.WARNING, "Move Mode: " + MovementModes[Settings.Default.SELECTED_MOVEMENT_MODE]); 
                    });
                Logging.Write(LogLevel.INFO, "Added Hotkey: " + _hotkeyToggleMovement.ToString());
            }

            // Hotkey To Add/Remove Target From Target List
            try { key = (Keys)(new KeysConverter()).ConvertFromString(text.ToTitleCase(Settings.Default.HOTKEY_ADD_REM_TARGET_LIST)); }
            catch (Exception e) { key = Keys.None; }
            if (key != Keys.None)
            {
                _hotkeyAddRemTargetTargetList = HotkeyManager.Register(
                    "HK_MUD_ADD_REM_TARGET",
                    key,
                    (ModifierKeys)Enum.Parse(typeof(ModifierKeys),
                        ModifierKeyStrings[Settings.Default.HOTKEY_MODIFIER_REM_TARGET_LIST]),
                    hkAddRemTargetTargetList =>
                    {
                        if (MudBase.LastTargetName == null) {
                            if (Settings.Default.UI_FLASH_MESSAGES)
                                FlashMessage.Flash(LogLevel.WARNING, "No Valid Last Target", FlashMessage.MessageSize.LARGE); 
                        } else if(Settings.Default.MOBS_TO_TARGET.Contains(MudBase.LastTargetName)) {
                            Settings.Default.MOBS_TO_TARGET.Remove(MudBase.LastTargetName);
                            SettingsForm.UpdateTargetDataGrid();
                            //SettingsForm.UpdateTargetDataGrid();
                            Logging.Write(LogLevel.INFO, "Removing {0} From Target List", MudBase.LastTargetName);
                            if (Settings.Default.UI_FLASH_MESSAGES)
                                FlashMessage.Flash(LogLevel.PRIMARY, "Removing Target: " + MudBase.LastTargetName,FlashMessage.MessageSize.LARGE); 
                        } else {
                            Settings.Default.MOBS_TO_TARGET.Add(MudBase.LastTargetName);
                            SettingsForm.UpdateTargetDataGrid();
                            Logging.Write(LogLevel.INFO, "Adding {0} To Target List", MudBase.LastTargetName);
                            if (Settings.Default.UI_FLASH_MESSAGES)
                                FlashMessage.Flash(LogLevel.WARNING, "Adding Target: " + MudBase.LastTargetName,FlashMessage.MessageSize.LARGE); }
                    });
                Logging.Write(LogLevel.INFO, "Added Hotkey: " + _hotkeyAddRemTargetTargetList.ToString());
            }
        }

        public static void UnregisterAllHotkeys()
        {
            MudBase.UnregisterHotkey(_hotkeyPause);
            MudBase.UnregisterHotkey(_hotkeyTargetMode);
            MudBase.UnregisterHotkey(_hotkeyToggleMovement);
            MudBase.UnregisterHotkey(_hotkeyAddTargetTargetList);
            MudBase.UnregisterHotkey(_hotkeyAddRemTargetTargetList);
            MudBase.UnregisterHotkey(_hotkeyToggleMovementMode);
        }

        public static void UnregisterHotkey(Hotkey hk)
        {
            if (hk != null) {
                HotkeyManager.Unregister(hk);
                Logging.Write(LogLevel.WARNING, "Unregistered Hotkey: " + hk.ToString()); }
        }

        #endregion Hotkeys

        #region Helper Methods

        public static GameObject GetClosestEnemyByName(StringCollection names) {
            //Logging.Write(LogLevel.INFO, "Finding nearest enemy to attack...");
            return GameObjectManager.GameObjects.Where(u => 
                    IsValidEnemy(u)
                    && (decimal) Core.Player.Location.Distance3D(u.Location) <= Settings.Default.MAX_TARGET_DISTANCE)
                .OrderBy(u => Core.Player.Location.Distance3D(u.Location)).FirstOrDefault();
        }

        public static List<Character> VisiblePartyMembers { get {
            List<Character> members = new List<Character>();
            if (!PartyManager.IsInParty)
                members.Add(Core.Player);
            else
                foreach (PartyMember pm in PartyManager.AllMembers) {
                    if (pm.IsInObjectManager)
                        members.Add((Character)GameObjectManager.GetObjectByObjectId(pm.ObjectId)); }
            return members;
        } }

        public static bool IsTank(Character c)
        {
            switch (c.CurrentJob)
            {
                case ClassJobType.Marauder:
                case ClassJobType.Warrior:
                case ClassJobType.Paladin:
                case ClassJobType.Gladiator:
                case ClassJobType.DarkKnight:
                    return true;
                default:
                    return false;
            }
        }

        public static void Assist(Character c)
        {
            GameObject target = GameObjectManager.GetObjectByObjectId(c.CurrentTargetId);
            if (target != null && target.IsTargetable && target.IsValid && target.CanAttack) {
                Logging.Write(LogLevel.INFO, "Assisting " + c.Name);
                target.Target(); }
        }

        public static bool IsValidEnemy(GameObject obj)
        {
            if (obj == null)
                return false;
            if (!(obj is Character))
                return false;
            Character c = (Character)obj;
            return !c.IsMe && !c.IsDead && c.IsValid && c.IsTargetable && c.IsVisible && c.CanAttack
                && (TargetListTypes[Settings.Default.SELECTED_TARGET_LIST_TYPE].Equals("None")
                    || (TargetListTypes[Settings.Default.SELECTED_TARGET_LIST_TYPE].Equals("Whitelist") 
                        && Settings.Default.MOBS_TO_TARGET.Contains(c.Name))
                    || (TargetListTypes[Settings.Default.SELECTED_TARGET_LIST_TYPE].Equals("Blacklist")
                        && !Settings.Default.MOBS_TO_TARGET.Contains(c.Name)));
        }

        public static Character PartyTank { get {
            if (VisiblePartyMembers.Count > 0)
                try {
                    return VisiblePartyMembers.First(p => IsTank(p)); } 
                catch (Exception e) { 
                    return null; }
                return null;
        } }

        public static bool InCombat
        {
            get
            {
                return VisiblePartyMembers.Where(p => 
                    p.IsAlive 
                    && p.HasTarget 
                    && p.InCombat
                    && p.TargetCharacter != null
                    && p.TargetCharacter.HasTarget
                    && p.TargetCharacter.CurrentHealth < p.TargetCharacter.MaxHealth
                ) != null;
            }
        }

        #endregion Helper Methods
    }
}
