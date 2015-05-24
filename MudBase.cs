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
using System.Linq;
using System.Windows.Forms;
using System.Windows.Input;
using TreeSharp;

namespace MudBase
{
    public class MudBase : BotBase
    {
        public static String[] ModifierKeyStrings = { "None", "Shift", "Control", "Alt" };
        public static String[] TargetingModes = { "None", "Assist Tank", "Nearest Enemy" };
        public static String[] TargetListTypes = { "Whitelist", "Blacklist" };
        public static String[] MoveTarget = { "Target", "Tank" };

        public override string Name { get { return "Mud Assist"; } }
        public override bool WantButton { get { return true; } }
        public override bool RequiresProfile { get { return false; } }
        public override ff14bot.Behavior.PulseFlags PulseFlags { get { return ff14bot.Behavior.PulseFlags.All; } }

        public override void OnButtonPress()
        {
            Logging.Write(LogLevel.INFO, "Opening Settings");
            SettingsForm settings = new SettingsForm();
            settings.ShowDialog();
        }

        public override void Start()
        {
            Navigator.PlayerMover = new SlideMover();
            Navigator.NavigationProvider = new GaiaNavigator();
            ResetHotkeys();
            Logging.Write(LogLevel.PRIMARY, "Started!");
        }

        public override void Stop()
        {
            UnregisterHotkey(_hotkeyPause);
            UnregisterHotkey(_hotkeyTargetMode);
            _root = null;
            Navigator.PlayerMover = new NullMover();
            Navigator.NavigationProvider = new NullProvider();
            Logging.Write(LogLevel.PRIMARY, "Stopped!");
        }

        private Composite _root;
        public override Composite Root { get {
            return _root ?? (_root =
                new Decorator( 
                    req => !Settings.Default.IS_PAUSED 
                        && !Core.Player.IsCasting 
                        && !Core.Player.IsMounted 
                        && (!MovementManager.IsMoving 
                            || Settings.Default.EXECUTE_WHILE_MOVING),
                    new PrioritySelector(
                        // Auto-Sprint
                        new Decorator(
                            req => Settings.Default.AUTO_SPRINT && !Core.Player.InCombat && Actionmanager.IsSprintReady && MovementManager.IsMoving,
                            new TreeSharp.Action(a => {Actionmanager.Sprint();})),
                        // Pre-Combat Buffs
                        new Decorator(
                            req => !Core.Player.InCombat && 
                                Settings.Default.COMBAT_ROUTINE_PRECOMBATBUFF, 
                            RoutineManager.Current.PreCombatBuffBehavior),
                        // Out Of Combat Healing
                        new Decorator(
                            req => (Core.Player.InCombat 
                                    || Settings.Default.HEAL_OUT_OF_COMBAT) 
                                && Settings.Default.COMBAT_ROUTINE_HEAL, 
                            RoutineManager.Current.HealBehavior),
                        new Decorator(
                            req => (Core.Player.InCombat 
                                || Settings.Default.ATTACK_OUT_OF_COMBAT),
                            new PrioritySelector (
                                // Combat Buffs
                                new Decorator(
                                    req => Settings.Default.COMBAT_ROUTINE_COMBATBUFF,
                                    RoutineManager.Current.CombatBuffBehavior),
                                // Find Suitable Target
                                new Decorator(
                                    req => (PartyManager.IsInParty 
                                        && TargetingModes[Settings.Default.SELECTED_TARGETING_MODE].Equals("Assist Tank") 
                                        && VisiblePartyMembers.Where(pm => IsTank(pm)).Count() > 0 
                                        && (!Core.Player.HasTarget 
                                            || !Core.Player.CurrentTarget.CanAttack)),
                                    new TreeSharp.Action(a => Assist(VisiblePartyMembers.Where(pm => IsTank(pm)).First()))),
                                new Decorator(
                                    req => TargetingModes[Settings.Default.SELECTED_TARGETING_MODE].Equals("Nearest Enemy") 
                                        && !Core.Player.HasTarget,
                                    new TreeSharp.Action(a => {
                                        GameObject target = GetClosestEnemyByName(Settings.Default.TARGET_MOB_LIST);
                                        if (target != null)
                                            target.Target();})),
                                // Stop Moving If Moving & In Range Of Target
                                new Decorator(
                                    req => Settings.Default.MOVE_TO_TARGET
                                        && MovementManager.IsMoving
                                        && GetMoveTarget() != Core.Player
                                        && Core.Player.Location.Distance3D(GetMoveTarget().Location) <= ((float)Settings.Default.MOVE_TARGET_RANGE),
                                    new TreeSharp.Action(a => { Navigator.PlayerMover.MoveStop(); })),
                                // Move To Target If Not In Range & Not On The Move
                                new Decorator(
                                    req => Settings.Default.MOVE_TO_TARGET
                                        && !MovementManager.IsMoving
                                        && GetMoveTarget() != Core.Player
                                        && Core.Player.Location.Distance3D(GetMoveTarget().Location) > ((float)Settings.Default.MOVE_TARGET_RANGE * 1.10),
                                    new TreeSharp.Action(a => { Navigator.PlayerMover.MoveTowards(GetMoveTarget().Location); })),
                                // Face Target If Facing Enabled
                                new Decorator(
                                    req => Settings.Default.AUTO_FACE_TARGET 
                                        && IsValidEnemy(Core.Player.CurrentTarget) 
                                        && !Core.Player.IsFacing(Core.Player.CurrentTarget),
                                    new TreeSharp.Action(a => {
                                        Core.Player.CurrentTarget.Face(); })),
                                // Combat Routine
                                new Decorator(
                                    req => Settings.Default.COMBAT_ROUTINE_COMBAT
                                        && IsValidEnemy(Core.Player.CurrentTarget)
                                        && (Settings.Default.TARGET_MOB_LIST.Count == 0
                                            || Settings.Default.TARGET_MOB_LIST[0].Length == 0 
                                            || ((TargetListTypes[Settings.Default.SELECTED_TARGET_LIST_TYPE].Equals("Blacklist")
                                                    && !Settings.Default.TARGET_MOB_LIST.Contains(Core.Player.CurrentTarget.Name)) 
                                                || (TargetListTypes[Settings.Default.SELECTED_TARGET_LIST_TYPE].Equals("Whitelist")
                                                    && Settings.Default.TARGET_MOB_LIST.Contains(Core.Player.CurrentTarget.Name)))),
                                    RoutineManager.Current.CombatBehavior))))));}
        }

        private static Hotkey _hotkeyPause;
        private static Hotkey _hotkeyTargetMode;
        public static void ResetHotkeys()
        {
            UnregisterHotkey(_hotkeyPause);
            UnregisterHotkey(_hotkeyTargetMode);
            
            // Hotkey To Pause / Unpause
            Logging.Write(LogLevel.INFO, "Setting Up Hotkeys");
            Keys key;
            try {key = (Keys)(new KeysConverter()).ConvertFromString(Settings.Default.HOTKEY_PAUSE.ToUpper());}
                catch (Exception e) {key = Keys.None;}
            if (key != Keys.None) {
                _hotkeyPause = HotkeyManager.Register(
                    "HK_MUD_PAUSE", 
                    key, 
                    (ModifierKeys)Enum.Parse(typeof(ModifierKeys), 
                    ModifierKeyStrings[Settings.Default.HOTKEY_PAUSE_MODIFIER]), 
                    action => {
                        Settings.Default.IS_PAUSED = !Settings.Default.IS_PAUSED;
                        if (Settings.Default.IS_PAUSED) {
                            Logging.Write(LogLevel.PRIMARY, "Paused");
                            if (Settings.Default.FLASH_MESSAGES)
                                FlashMessage.Flash(LogLevel.DANGER, "Paused"); 
                        } else {
                            Logging.Write(LogLevel.PRIMARY, "Unpaused");
                            if(Settings.Default.FLASH_MESSAGES)
                                FlashMessage.Flash(LogLevel.SUCCESS, "Unpaused"); 
                        }});
                Logging.Write(LogLevel.INFO, "Added Hotkey: " + _hotkeyPause.ToString()); }

            // Hotkey To Change Targeting Mode
            try { key = (Keys)(new KeysConverter()).ConvertFromString(Settings.Default.HOTKEY_TARGET_MODE.ToUpper()); }
                catch (Exception e) { key = Keys.None; }
            if (key != Keys.None) {
                _hotkeyTargetMode = HotkeyManager.Register(
                    "HK_MUD_TARGET", 
                    (Keys)(new KeysConverter()).ConvertFromString(Settings.Default.HOTKEY_TARGET_MODE.ToUpper()), 
                    (ModifierKeys)Enum.Parse(typeof(ModifierKeys), 
                    ModifierKeyStrings[Settings.Default.HOTKEY_TARGET_MODE_MODIFIER]), 
                    action => {
                        //Logging.Write(LogLevel.PRIMARY, "Previous Targeting Mode: " + TargetingModes[Settings.Default.SELECTED_TARGETING_MODE]);
                        if ((Settings.Default.SELECTED_TARGETING_MODE+1) == TargetingModes.Length)
                            Settings.Default.SELECTED_TARGETING_MODE = 0;
                        else
                            Settings.Default.SELECTED_TARGETING_MODE = (Settings.Default.SELECTED_TARGETING_MODE + 1);
                        SettingsForm.SelectTargetingMode(Settings.Default.SELECTED_TARGETING_MODE);
                        Logging.Write(LogLevel.PRIMARY, "Target Mode: " + TargetingModes[Settings.Default.SELECTED_TARGETING_MODE]);
                        if (Settings.Default.FLASH_MESSAGES)
                            FlashMessage.Flash(LogLevel.WARNING, "Target: " + TargetingModes[Settings.Default.SELECTED_TARGETING_MODE]); 
                        });
                Logging.Write(LogLevel.INFO, "Added Hotkey: " + _hotkeyTargetMode.ToString()); }
        }

        public static void UnregisterHotkey(Hotkey hk)
        {
            if (hk != null) {
                Logging.Write(LogLevel.INFO, "Unregistering Hotkey: " + hk.ToString());
                HotkeyManager.Unregister(hk); }
        }

        public GameObject GetClosestEnemyByName(StringCollection names) {
            Logging.Write(LogLevel.INFO, "Finding nearest enemy to attack...");
            return GameObjectManager.GameObjects.Where(u => 
                    IsValidEnemy(u)
                    && (decimal) Core.Player.Location.Distance3D(u.Location) <= Settings.Default.TARGETING_DISTANCE)
                .OrderBy(u => Core.Player.Location.Distance3D(u.Location)).FirstOrDefault();
        }

        public List<Character> VisiblePartyMembers { get {
            List<Character> members = new List<Character>();
            if (!PartyManager.IsInParty)
                members.Add(Core.Player);
            else
                foreach (PartyMember pm in PartyManager.AllMembers) {
                    if (pm.IsInObjectManager)
                        members.Add((Character)GameObjectManager.GetObjectByObjectId(pm.ObjectId)); }
            return members;
        } }

        public bool IsTank(Character c)
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

        public void Assist(Character c)
        {
            GameObject target = GameObjectManager.GetObjectByObjectId(c.CurrentTargetId);
            if (target != null && target.IsTargetable && target.IsValid && target.CanAttack) {
                Logging.Write(LogLevel.INFO, "Assisting " + c.Name);
                target.Target(); }
        }

        public Character GetMoveTarget()
        {
            Character targ = Core.Player;
            IEnumerable<Character> tanks = VisiblePartyMembers.Where(p => IsTank(p));
            if (tanks.Count() > 0 && MudBase.MoveTarget[Settings.Default.SELECTED_MOVE_TARGET].Equals("Tank"))
                targ = tanks.First();
            else if (IsValidEnemy(Core.Player.CurrentTarget) && MudBase.MoveTarget[Settings.Default.SELECTED_MOVE_TARGET].Equals("Target"))
                targ = (Character)Core.Player.CurrentTarget;
            return targ;
        }

        public bool IsValidEnemy(GameObject obj)
        {
            if (obj == null)
                return false;
            if (!(obj is Character))
                return false;
            Character c = (Character)obj;
            return !c.IsMe && !c.IsDead && c.IsValid && c.IsTargetable && c.IsVisible && c.CanAttack 
                && ((TargetListTypes[Settings.Default.SELECTED_TARGET_LIST_TYPE].Equals("Whitelist") 
                        && Settings.Default.TARGET_MOB_LIST.Contains(c.Name))
                    || (TargetListTypes[Settings.Default.SELECTED_TARGET_LIST_TYPE].Equals("Blacklist")
                        && !Settings.Default.TARGET_MOB_LIST.Contains(c.Name)));
        }
    }
}
