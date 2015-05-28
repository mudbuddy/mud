using ff14bot.Managers;
using Mud.Helpers;
using Mud.Properties;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Mud
{
    public partial class SettingsForm : Form
    {
        private static SettingsForm Instance;
        public SettingsForm()
        {
            InitializeComponent();
            Instance                    = this;
            this.TopMost                = Settings.Default.UI_ALWAYS_ON_TOP;
            this.Text                   = "Mud Assist v" + MudBase.Version + " Settings";
            dgvTargetList.DataSource    = new BindingList<StringValue>();
            DataGridViewColumn column   = dgvTargetList.Columns[0];
            column.Width                = dgvTargetList.Width - 65;
            dgvTargetList.DataError     += OnDataErrorTargetList;
            ReloadSettings();
            UpdateStatus();
        }

        #region Custom Methods

        public static void UpdateStatus()
        {
            if (Instance != null)
            {
                if (Settings.Default.COMBAT_ROUTINE_PAUSED) {
                    Instance.tspPauseStatus.Text = "STOPPED";
                    Instance.tspPauseStatus.ForeColor = LogLevel.DANGER.DrawingDark;
                } 
                else 
                {
                    Instance.tspPauseStatus.Text = "RUNNING";
                    Instance.tspPauseStatus.ForeColor = LogLevel.SUCCESS.DrawingDark;
                }
                if (Settings.Default.AUTO_MOVE)
                {
                    Instance.tspMovementStatus.Text = "+AMOVE";
                    Instance.tspMovementStatus.ForeColor = LogLevel.PRIMARY.DrawingDark;
                }
                else
                {
                    Instance.tspMovementStatus.Text = "-AMOVE";
                    Instance.tspMovementStatus.ForeColor = LogLevel.WARNING.DrawingDark;
                }
                Instance.tspFollowModeStatus.Text = "M: " + MudBase.MovementModes[Settings.Default.SELECTED_MOVEMENT_MODE].ToUpper();
                Instance.tspTargetModeStatus.Text = "T: " + MudBase.TargetingModes[Settings.Default.SELECTED_TARGETING_MODE].ToUpper();
            }
        }

        public static void SelectTargetingMode(int p)
        {
            if (Instance != null)
                Instance.cmbTargetingMode.SelectedIndex = p;
        }

        public static void SelectMovementMode(int p)
        {
            if (Instance != null)
                Instance.cmbMovementMode.SelectedIndex = p;
        }

        public static void UpdateTargetDataGrid()
        {
            if (Instance != null && Instance.dgvTargetList != null && Instance.dgvTargetList.DataSource != null)
            {
                BindingList<StringValue> targets = (BindingList<StringValue>)Instance.dgvTargetList.DataSource;
                targets.Clear();
                foreach (String s in Settings.Default.MOBS_TO_TARGET)
                {
                    targets.Add(new StringValue(s));
                }
                Instance.dgvTargetList.Refresh();
            }
        }

        private void ReloadSettings()
        {
            cmbHotkeyModifierPause.Items.Clear();
            cmbHotkeyModifierPause.Items.AddRange(MudBase.ModifierKeyStrings);
            cmbHotkeyModifierPause.SelectedIndex = Properties.Settings.Default.HOTKEY_MODIFIER_PAUSE;
            cmbHotkeyModifierTargetMode.Items.Clear();
            cmbHotkeyModifierTargetMode.Items.AddRange(MudBase.ModifierKeyStrings);
            cmbHotkeyModifierTargetMode.SelectedIndex = Properties.Settings.Default.HOTKEY_MODIFIER_TARGET_MODE;
            cmbTargetingMode.Items.Clear();
            cmbTargetingMode.Items.AddRange(MudBase.TargetingModes);
            SelectTargetingMode(Properties.Settings.Default.SELECTED_TARGETING_MODE);
            cmbTargetListType.Items.Clear();
            cmbTargetListType.Items.AddRange(MudBase.TargetListTypes);
            cmbTargetListType.SelectedIndex = Properties.Settings.Default.SELECTED_TARGET_LIST_TYPE;
            cmbMovementMode.Items.Clear();
            cmbMovementMode.Items.AddRange(MudBase.MovementModes);
            cmbMovementMode.SelectedIndex = Properties.Settings.Default.SELECTED_MOVEMENT_MODE;
            cmbHotkeyModifierMovement.Items.Clear();
            cmbHotkeyModifierMovement.Items.AddRange(MudBase.ModifierKeyStrings);
            cmbHotkeyModifierMovement.SelectedIndex = Properties.Settings.Default.HOTKEY_MODIFIER_TOGGLE_MOVEMENT;
            cmbHotkeyModifierAddRemTargetList.Items.Clear();
            cmbHotkeyModifierAddRemTargetList.Items.AddRange(MudBase.ModifierKeyStrings);
            cmbHotkeyModifierAddRemTargetList.SelectedIndex = Properties.Settings.Default.HOTKEY_MODIFIER_REM_TARGET_LIST;
            cmbHotkeyModifierToggleMoveMode.Items.Clear();
            cmbHotkeyModifierToggleMoveMode.Items.AddRange(MudBase.ModifierKeyStrings);
            cmbHotkeyModifierToggleMoveMode.SelectedIndex = Properties.Settings.Default.HOTKEY_MODIFIER_MOVEMENT_MODE;
            cbxAutoFace.Checked = GameSettingsManager.FaceTargetOnAction;
            cmbNavigationProvider.Items.Clear();
            cmbNavigationProvider.Items.AddRange(MudBase.SupportedNavigationProviders);
            cmbNavigationProvider.SelectedIndex = Properties.Settings.Default.SELECTED_NAVIGATION_PROVIDER;
            cmbCombatRoutines.Items.Clear();
            RoutineManager.Routines.ForEach(r => cmbCombatRoutines.Items.Add(r.Name));
            cmbCombatRoutines.SelectedIndex = cmbCombatRoutines.Items.IndexOf(RoutineManager.Current.Name);
            UpdateTargetDataGrid();
        }

        private void UpdateTargetSettings(object sender, EventArgs e)
        {
            if (this.dgvTargetList != null && this.dgvTargetList.DataSource != null && this.dgvTargetList.RowCount > 0)
            {
                Settings.Default.MOBS_TO_TARGET.Clear();
                foreach (StringValue sv in (BindingList<StringValue>)this.dgvTargetList.DataSource)
                {
                    Settings.Default.MOBS_TO_TARGET.Add(sv.Name);
                }
            }
        }

        #endregion Custom Methods

        #region Misc Events

        private void OnDataErrorTargetList(object sender, DataGridViewDataErrorEventArgs e)
        {
            Logging.Write(LogLevel.WARNING, "Data Error: Try again if target was not successfully added/removed.");
        }

        #endregion Misc Events

        #region Button Events

        private void OnClickSave(object sender, EventArgs e)
        {
            UpdateTargetSettings(sender, e);
            Properties.Settings.Default.Save();
            MudBase.ResetHotkeys();
            Logging.Write(LogLevel.PRIMARY, "Settings Saved!");
        }

        private void OnClickSaveAndClose(object sender, EventArgs e)
        {
            UpdateTargetSettings(sender, e);
            Properties.Settings.Default.Save();
            MudBase.ResetHotkeys();
            Logging.Write(LogLevel.PRIMARY, "Settings Saved & Closed!");
            this.Close();
        }

        private void OnClickReset(object sender, EventArgs e)
        {
            Logging.Write(LogLevel.DANGER, "Settings Reset To Default!");
            Properties.Settings.Default.Reset();
            ReloadSettings();
        }

        private void OnClickAddTargetList(object sender, EventArgs e)
        {
            if (MudBase.LastTargetName != null && !Settings.Default.MOBS_TO_TARGET.Contains(MudBase.LastTargetName))
            {
                Settings.Default.MOBS_TO_TARGET.Add(MudBase.LastTargetName);
                UpdateTargetDataGrid();
                //FlashMessage.ActivateFFXIV();
                Logging.Write(LogLevel.INFO, "Adding {0} To Target List", MudBase.LastTargetName);
            }
        }

        private void OnClickRemoveTargetList(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvTargetList.SelectedRows)
            {
                if (row != dgvTargetList.Rows[dgvTargetList.Rows.Count - 1])
                    Settings.Default.MOBS_TO_TARGET.Remove(((StringValue)row.DataBoundItem).Name);
            }
            UpdateTargetDataGrid();
            //FlashMessage.ActivateFFXIV();
            Logging.Write(LogLevel.INFO, "Removing Selection From Target List");
        }

        #endregion Button Events

        #region CheckBox Events

        private void OnCheckedAlwaysOnTop(object sender, EventArgs e)
        {
            this.TopMost = ((CheckBox)sender).Checked;
        }

        private void OnCheckedAutoFace(object sender, EventArgs e)
        {
            GameSettingsManager.FaceTargetOnAction = cbxAutoFace.Checked;
        }

        #endregion CheckBox Events

        #region ComboBox Events

        private void OnSelectedHotkeyModifierMovement(object sender, EventArgs e)
        {
            Properties.Settings.Default.HOTKEY_MODIFIER_TOGGLE_MOVEMENT = ((ComboBox)sender).SelectedIndex;
        }

        private void OnSelectedHotkeyModifierAddTargetList(object sender, EventArgs e)
        {
            Properties.Settings.Default.HOTKEY_MODIFIER_ADD_TARGET_LIST = ((ComboBox)sender).SelectedIndex;
        }

        private void OnSelectedHotkeyModifierRemoveTargetList(object sender, EventArgs e)
        {
            Properties.Settings.Default.HOTKEY_MODIFIER_REM_TARGET_LIST = ((ComboBox)sender).SelectedIndex;
        }

        private void OnSelectedHotkeyModifierPause(object sender, EventArgs e)
        {
            Properties.Settings.Default.HOTKEY_MODIFIER_PAUSE = ((ComboBox)sender).SelectedIndex;
        }

        private void OnSelectedHotkeyModifierTargetMode(object sender, EventArgs e)
        {
            Properties.Settings.Default.HOTKEY_MODIFIER_TARGET_MODE = ((ComboBox)sender).SelectedIndex;
        }

        private void OnSelectedHotkeyModifierMovementMode(object sender, EventArgs e)
        {
            Properties.Settings.Default.HOTKEY_MODIFIER_MOVEMENT_MODE = ((ComboBox)sender).SelectedIndex;
        }

        private void OnSelectedMoveTarget(object sender, EventArgs e)
        {
            Properties.Settings.Default.SELECTED_MOVEMENT_MODE = ((ComboBox)sender).SelectedIndex;
        }

        private void OnSelectedNavigationProvider(object sender, EventArgs e)
        {
            Properties.Settings.Default.SELECTED_NAVIGATION_PROVIDER = ((ComboBox)sender).SelectedIndex;
            MudBase.UpdateNavigationProvider();
        }

        private void OnSelectedTargetingMode(object sender, EventArgs e)
        {
            Properties.Settings.Default.SELECTED_TARGETING_MODE = ((ComboBox)sender).SelectedIndex;
        }

        private void OnSelectedTargetListType(object sender, EventArgs e)
        {
            Properties.Settings.Default.SELECTED_TARGET_LIST_TYPE = ((ComboBox)sender).SelectedIndex;
        }

        private void OnSelectedCombatRoutine(object sender, EventArgs e)
        {
            String selected = (sender as ComboBox).Items[(sender as ComboBox).SelectedIndex].ToString();
            if (selected.Equals(RoutineManager.Current.Name))
                return;
            RoutineManager.Current.ShutDown();
            RoutineManager.PreferedRoutine = (sender as ComboBox).Items[(sender as ComboBox).SelectedIndex].ToString();
            RoutineManager.PickRoutine();
            Logging.Write(LogLevel.DANGER, "Combat Routine Changed, Press Stop And Start Button For Changes To Take Effect.");
        }

        #endregion ComboBox Events
    }
}
