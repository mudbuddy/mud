using ff14bot;
using ff14bot.AClasses;
using ff14bot.Enums;
using ff14bot.Managers;
using ff14bot.Navigation;
using ff14bot.Objects;
using MudBase.Helpers;
using MudBase.Properties;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Input;
using TreeSharp;

namespace MudBase
{
    public class MudBase : BotBase
    {
        public static String[] ModifierKeyStrings = { "None", "Shift", "Control", "Alt" };
        public static String[] TargetingModes = { "None", "Assist Tank", "Nearest Enemy" };
        public static String[] TargetListTypes = { "None", "Whitelist", "Blacklist" };
        public static String[] MoveTarget = { "Target", "Tank" };

        public override string Name { get { return "Mud Assist"; } }
        public override bool WantButton { get { return true; } }
        public override bool RequiresProfile { get { return false; } }
        public override ff14bot.Behavior.PulseFlags PulseFlags { get { return ff14bot.Behavior.PulseFlags.All; } }
        public static String LastTargetName = null;
        public const String Version = "1.1.3.4";

        public override void OnButtonPress()
        {
            Logging.Write(LogLevel.INFO, "Opening Settings");
            SettingsForm settings = new SettingsForm();
            settings.ShowDialog();
        }

        public override void Initialize()
        {
            Logging.Write(LogLevel.PRIMARY, "Initializing");
            Navigator.NavigationProvider = new NullProvider();
            ResetHotkeys();
        }

        public override void Start()
        {
            Navigator.PlayerMover = new SlideMover();
            Logging.Write(LogLevel.PRIMARY, "Started");
            ResetHotkeys();
        }

        public override void Stop()
        {
            _root = null;
            Navigator.PlayerMover = new NullMover();
            Logging.Write(LogLevel.PRIMARY, "Stopped!");
            UnregisterAllHotkeys();
        }

        public bool TreeTick()
        {
            if(Core.Player.CurrentTarget != null && Core.Player.CurrentTarget.Name != null)
                LastTargetName = Core.Player.CurrentTarget.Name;
            return true;
        }

        private Composite _root;
        public override Composite Root { get {
            return _root ?? (_root =
                new Decorator( 
                    req => TreeTick()
                        && !Settings.Default.COMBAT_ROUTINE_PAUSED 
                        && !Core.Player.IsCasting 
                        && (!MovementManager.IsMoving 
                            || Settings.Default.COMBAT_ROUTINE_EXECUTE_WHILE_MOVING),
                    new PrioritySelector(
                        // Auto-Sprint
                        new Decorator(
                            req => Settings.Default.AUTO_SPRINT 
                                && !Core.Player.InCombat 
                                && Actionmanager.IsSprintReady 
                                && MovementManager.IsMoving
                                && !Core.Player.IsMounted,
                            new TreeSharp.Action(a => {Actionmanager.Sprint();})),
                        // Pre-Combat Buffs
                        new Decorator(
                            req => !Core.Player.InCombat && 
                                Settings.Default.COMBAT_ROUTINE_PRECOMBATBUFF
                                && !Core.Player.IsMounted, 
                            RoutineManager.Current.PreCombatBuffBehavior),
                        // Out Of Combat Healing
                        new Decorator(
                            req => (Core.Player.InCombat 
                                    || Settings.Default.COMBAT_ROUTINE_HEAL_OUT_OF_COMBAT) 
                                && Settings.Default.COMBAT_ROUTINE_HEAL
                                && !Core.Player.IsMounted, 
                            RoutineManager.Current.HealBehavior),
                        // Stop Moving If Moving & In Range Of Target
                        new Decorator(
                            req => Settings.Default.AUTO_MOVE_TO_TARGET
                                && MovementManager.IsMoving
                                && GetMoveTarget() != Core.Player
                                && Core.Player.Location.Distance3D(GetMoveTarget().Location) <= ((float)Settings.Default.AUTO_MOVE_TARGET_RANGE_MIN),
                            new TreeSharp.Action(a => { Navigator.PlayerMover.MoveStop(); })),
                        // Move To Target If Not In Range & Not On The Move
                        new Decorator(
                            req => Settings.Default.AUTO_MOVE_TO_TARGET
                                && !Core.Player.IsCasting
                                && GetMoveTarget() != Core.Player
                                && Core.Player.Location.Distance3D(GetMoveTarget().Location) > (float)Settings.Default.AUTO_MOVE_TARGET_RANGE_MAX,
                            new TreeSharp.Action(a => { Navigator.PlayerMover.MoveTowards(GetMoveTarget().Location); })),
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
                        new Decorator(
                            req => (Core.Player.InCombat 
                                || (Settings.Default.COMBAT_ROUTINE_ATTACK_OUT_OF_COMBAT 
                                    && !PartyManager.IsInParty) 
                                || (Settings.Default.COMBAT_ROUTINE_ATTACK_OUT_OF_COMBAT
                                    && TargetingModes[Settings.Default.SELECTED_TARGETING_MODE].Equals("Assist Tank")
                                    && PartyManager.IsInParty 
                                    && PartyTank != null 
                                    && PartyTank.InCombat)),
                            new PrioritySelector (
                                // Combat Buffs
                                new Decorator(
                                    req => Settings.Default.COMBAT_ROUTINE_COMBATBUFF
                                         && !Core.Player.IsMounted,
                                    RoutineManager.Current.CombatBuffBehavior),
                                //// Face Target If Facing Enabled
                                //new Decorator(
                                //    req => Settings.Default.AUTO_FACE_TARGET 
                                //        && IsValidEnemy(Core.Player.CurrentTarget) 
                                //        && !Core.Player.IsFacing(Core.Player.CurrentTarget),
                                //    new TreeSharp.Action(a => {
                                //        Core.Player.CurrentTarget.Face(); })),
                                // Combat Routine
                                new Decorator(
                                    req => Settings.Default.COMBAT_ROUTINE_COMBAT
                                        && !Core.Player.IsMounted
                                        && IsValidEnemy(Core.Player.CurrentTarget),
                                    RoutineManager.Current.CombatBehavior))))));}
        }

        private static Hotkey _hotkeyPause;
        private static Hotkey _hotkeyTargetMode;
        private static Hotkey _hotkeyToggleMovement;
        private static Hotkey _hotkeyAddTargetTargetList;
        private static Hotkey _hotkeyAddRemTargetTargetList;
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
                        Settings.Default.AUTO_MOVE_TO_TARGET = !Settings.Default.AUTO_MOVE_TO_TARGET;
                        if (Settings.Default.AUTO_MOVE_TO_TARGET)
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

        private static void UnregisterAllHotkeys()
        {
            UnregisterHotkey(_hotkeyPause);
            UnregisterHotkey(_hotkeyTargetMode);
            UnregisterHotkey(_hotkeyToggleMovement);
            UnregisterHotkey(_hotkeyAddTargetTargetList);
            UnregisterHotkey(_hotkeyAddRemTargetTargetList);
        }

        public static void UnregisterHotkey(Hotkey hk)
        {
            if (hk != null) {
                HotkeyManager.Unregister(hk);
                Logging.Write(LogLevel.WARNING, "Unregistered Hotkey: " + hk.ToString()); }
        }

        public GameObject GetClosestEnemyByName(StringCollection names) {
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

        public static Character GetMoveTarget()
        {
            Character targ = Core.Player;
            IEnumerable<Character> tanks = VisiblePartyMembers.Where(p => IsTank(p));
            if (tanks.Count() > 0 && MudBase.MoveTarget[Settings.Default.SELECTED_MOVE_TARGET].Equals("Tank"))
                targ = tanks.First();
            else if (IsValidEnemy(Core.Player.CurrentTarget) && MudBase.MoveTarget[Settings.Default.SELECTED_MOVE_TARGET].Equals("Target"))
                targ = (Character)Core.Player.CurrentTarget;
            return targ;
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

        public Character PartyTank { get {
            if (VisiblePartyMembers.Count > 0)
                try {
                    return VisiblePartyMembers.First(p => IsTank(p)); } 
                catch (Exception e) { 
                    return null; }
                return null;
        } }
    }
}
