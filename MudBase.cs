using ff14bot;
using ff14bot.AClasses;
using ff14bot.Enums;
using ff14bot.Managers;
using ff14bot.Navigation;
using ff14bot.Objects;
using MudBase.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using TreeSharp;

namespace MudBase
{
    public class MudBase : BotBase
    {
        public override string Name { get { return "Mud Assist"; } }
        public override bool WantButton { get { return true; } }
        public override bool RequiresProfile { get { return false; } }
        public override ff14bot.Behavior.PulseFlags PulseFlags { get { return ff14bot.Behavior.PulseFlags.All; } }
        
        public override void OnButtonPress()
        {
            Logging.Write(LogLevel.INFO, "Opening Settings");
            Form settings = new SettingsForm();
            settings.ShowDialog();
        }

        public override void Start()
        {
            Navigator.PlayerMover = new NullMover();
            Navigator.NavigationProvider = new NullProvider();
            ResetHotkeys();
            Logging.Write(LogLevel.PRIMARY, "Started!");
        }

        public override void Stop()
        {
            Logging.Write(LogLevel.PRIMARY, "Stopped!");
        }

        private Composite _root;
        public override Composite Root
        {
            get 
            {
                return _root ?? (_root =
                    new Decorator( req => !Settings.Default.IS_PAUSED && !Core.Player.IsCasting && !Core.Player.IsMounted && !MovementManager.IsMoving,
                        new PrioritySelector(
                            new Decorator(r => !Core.Player.InCombat && Settings.Default.COMBAT_ROUTINE_PRECOMBATBUFF, RoutineManager.Current.PreCombatBuffBehavior),
                            new Decorator(r => (Core.Player.InCombat || Settings.Default.HEAL_OUT_OF_COMBAT) && Settings.Default.COMBAT_ROUTINE_HEAL, RoutineManager.Current.HealBehavior),
                            new Decorator(r => (Core.Player.InCombat || Settings.Default.ATTACK_OUT_OF_COMBAT),
                                new PrioritySelector (
                                    new Decorator(r => Settings.Default.COMBAT_ROUTINE_COMBATBUFF,
                                        RoutineManager.Current.CombatBuffBehavior
                                    ),
                                    new Decorator(req => (PartyManager.IsInParty && TargetingModes[Settings.Default.TARGETING_MODE].Equals("Assist Tank") && GetPartyTank() != null && (!Core.Player.HasTarget || !Core.Player.CurrentTarget.CanAttack)),
                                        new TreeSharp.Action(a => AssistPartyMember(GetPartyTank()))
                                    ),
                                    new Decorator(req => TargetingModes[Settings.Default.TARGETING_MODE].Equals("Nearest Enemy") && (!Core.Player.HasTarget),
                                        new TreeSharp.Action(a => {
                                            GameObject target = GetClosestEnemyByName(TargetMobList);
                                            if (target != null)
                                                target.Target();
                                        })
                                    ),
                                    new Decorator(req => (TargetMobList.Count == 0 || TargetMobList.First().Length == 0 || (Core.Player.HasTarget && (TargetMobList.Contains(Core.Player.CurrentTarget.Name)))) && Settings.Default.COMBAT_ROUTINE_COMBAT,
                                        RoutineManager.Current.CombatBehavior
                                    )
                                )
                            )
                        )
                    )
                );
            }
        }

        public static String[] ModifierKeyStrings = { "None", "Shift", "Control", "Alt" };
        public static String[] TargetingModes = { "None", "Assist Tank", "Nearest Enemy" };
        private static Hotkey _hotkeyPause;
        private static Hotkey _hotkeyTargetMode;
        public static void ResetHotkeys()
        {
            UnregisterHotkey(_hotkeyPause);
            UnregisterHotkey(_hotkeyTargetMode);
            // PAUSE HOTKEY
            Logging.Write(LogLevel.INFO, "Setting Up Hotkeys");
            Keys key;
            try {key = (Keys)(new KeysConverter()).ConvertFromString(Settings.Default.HOTKEY_PAUSE.ToUpper());}
                catch (Exception e) {key = Keys.None;}
            if (key != Keys.None)
            {
                _hotkeyPause = HotkeyManager.Register("HK_MUD_PAUSE", key, (ModifierKeys)Enum.Parse(typeof(ModifierKeys), ModifierKeyStrings[Settings.Default.HOTKEY_PAUSE_MODIFIER]), a =>
                {
                    Settings.Default.IS_PAUSED = !Settings.Default.IS_PAUSED;
                    if (Settings.Default.IS_PAUSED)
                        Logging.Write(LogLevel.PRIMARY, "Paused");
                    else
                        Logging.Write(LogLevel.PRIMARY, "Unpaused");
                });
                Logging.Write(LogLevel.INFO, "Added Hotkey: " + _hotkeyPause.ToString());
            }
            // TARGET MODE HOTKEY
            try { key = (Keys)(new KeysConverter()).ConvertFromString(Settings.Default.HOTKEY_TARGET_MODE.ToUpper()); }
                catch (Exception e) { key = Keys.None; }
            if (key != Keys.None)
            {
                _hotkeyTargetMode = HotkeyManager.Register("HK_MUD_TARGET", (Keys)(new KeysConverter()).ConvertFromString(Settings.Default.HOTKEY_TARGET_MODE.ToUpper()), (ModifierKeys)Enum.Parse(typeof(ModifierKeys), ModifierKeyStrings[Settings.Default.HOTKEY_TARGET_MODE_MODIFIER]), a =>
                {
                    Logging.Write(LogLevel.PRIMARY, "Previous Targeting Mode: " + TargetingModes[Settings.Default.TARGETING_MODE]);
                    if (Settings.Default.TARGETING_MODE == (TargetingModes.Length - 1))
                        Settings.Default.TARGETING_MODE = 0;
                    else
                        Settings.Default.TARGETING_MODE = (Settings.Default.TARGETING_MODE + 1);
                    SettingsForm.SelectTargetingMode(Settings.Default.TARGETING_MODE);
                    Logging.Write(LogLevel.PRIMARY, "Current Targeting Mode: " + TargetingModes[Settings.Default.TARGETING_MODE]);
                });
                Logging.Write(LogLevel.INFO, "Added Hotkey: " + _hotkeyTargetMode.ToString());
            }
        }

        public static void UnregisterHotkey(Hotkey hk)
        {
            if (hk != null)
            {
                Logging.Write(LogLevel.INFO, "Unregistering Hotkey: " + hk.ToString());
                HotkeyManager.Unregister(hk);
            }
        }

        public static List<String> TargetMobList = Settings.Default.TARGET_MOB_LIST.Split('\n').ToList();
        public GameObject GetClosestEnemyByName(List<String> names) {
            Logging.Write(LogLevel.INFO, "Finding nearest enemy to attack...");
            return GameObjectManager.GameObjects.Where(u => u.CanAttack).OrderBy(u => u.Distance2D()).Where(u => names.Count == 0 || (names.Count == 1 && names.First().Equals("")) || names.Contains(u.Name)).FirstOrDefault();
        }

        public PartyMember GetPartyTank()
        {
            if (!PartyManager.IsInParty)
            {
                Logging.Write(LogLevel.DANGER, "No Party Tank, Not in party!");
                return null;
            }
            foreach (PartyMember p in PartyManager.AllMembers)
            {
                switch (p.Class)
                {
                    case ClassJobType.Marauder:
                    case ClassJobType.Warrior:
                    case ClassJobType.Paladin:
                    case ClassJobType.Gladiator:
                        Logging.Write(LogLevel.SUCCESS,"Found Party Tank: " + p.Name);
                        return p;
                }
            }
            Logging.Write(LogLevel.DANGER, "No Party Tank Found!");
            return null;
        }

        public void AssistPartyMember(PartyMember p)
        {
            Logging.Write(LogLevel.INFO, "Attempting to assist " + p.Name);
            if (p != null && p.IsInObjectManager)
            {
                Character pm = (Character)GameObjectManager.GetObjectByObjectId(p.ObjectId);
                GameObject assist = GameObjectManager.GetObjectByObjectId(pm.CurrentTargetId);
                if (assist != null && assist.IsTargetable && assist.IsValid && assist.CanAttack)
                    assist.Target();
            }
        }
    }
}
