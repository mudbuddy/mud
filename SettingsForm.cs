using ff14bot;
using ff14bot.Managers;
using ff14bot.Objects;
using MudBase.Helpers;
using MudBase.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace MudBase
{
    public partial class SettingsForm : Form
    {
        private static SettingsForm Instance;
        public SettingsForm()
        {
            InitializeComponent();
            Instance = this;
            this.TopMost = Settings.Default.UI_ALWAYS_ON_TOP;
            this.Text = "Mud Assist v" + MudBase.Version + " Settings";
            dataGridView1.DataSource = new BindingList<StringValue>();
            DataGridViewColumn column = dataGridView1.Columns[0];
            column.Width = dataGridView1.Width - 65;
            dataGridView1.DataError += dataGridView1_DataError;
            ReloadSettings();
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            Logging.Write(LogLevel.WARNING,"Data Error: Try again if target was not successfully added/removed.");
        }

        public static void SelectTargetingMode(int p)
        {
            if(Instance != null)
                Instance.comboBox3.SelectedIndex = p;
        }

        private void ReloadSettings()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(MudBase.ModifierKeyStrings);
            comboBox1.SelectedIndex = Properties.Settings.Default.HOTKEY_MODIFIER_PAUSE;
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(MudBase.ModifierKeyStrings);
            comboBox2.SelectedIndex = Properties.Settings.Default.HOTKEY_MODIFIER_TARGET_MODE;
            comboBox3.Items.Clear();
            comboBox3.Items.AddRange(MudBase.TargetingModes);
            SelectTargetingMode(Properties.Settings.Default.SELECTED_TARGETING_MODE);
            comboBox4.Items.Clear();
            comboBox4.Items.AddRange(MudBase.TargetListTypes);
            comboBox4.SelectedIndex = Properties.Settings.Default.SELECTED_TARGET_LIST_TYPE;
            comboBox5.Items.Clear();
            comboBox5.Items.AddRange(MudBase.MoveTarget);
            comboBox5.SelectedIndex = Properties.Settings.Default.SELECTED_MOVE_TARGET;
            comboBox6.Items.Clear();
            comboBox6.Items.AddRange(MudBase.ModifierKeyStrings);
            comboBox6.SelectedIndex = Properties.Settings.Default.HOTKEY_MODIFIER_TOGGLE_MOVEMENT;
            comboBox8.Items.Clear();
            comboBox8.Items.AddRange(MudBase.ModifierKeyStrings);
            comboBox8.SelectedIndex = Properties.Settings.Default.HOTKEY_MODIFIER_REM_TARGET_LIST;
            checkBox9.Checked = GameSettingsManager.FaceTargetOnAction;
            UpdateTargetDataGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateTargetSettings(sender, e);
            Properties.Settings.Default.Save();
            MudBase.ResetHotkeys();
            Logging.Write(LogLevel.PRIMARY, "Settings Saved & Updated!");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Logging.Write(LogLevel.DANGER, "Settings Reset To Default!");
            Properties.Settings.Default.Reset();
            ReloadSettings();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.HOTKEY_MODIFIER_PAUSE = ((ComboBox)sender).SelectedIndex;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.HOTKEY_MODIFIER_TARGET_MODE = ((ComboBox)sender).SelectedIndex;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.SELECTED_TARGETING_MODE = ((ComboBox)sender).SelectedIndex;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.SELECTED_TARGET_LIST_TYPE = ((ComboBox)sender).SelectedIndex;
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.SELECTED_MOVE_TARGET = ((ComboBox)sender).SelectedIndex;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MudBase.LastTargetName != null && !Settings.Default.MOBS_TO_TARGET.Contains(MudBase.LastTargetName)) { 
                Settings.Default.MOBS_TO_TARGET.Add(MudBase.LastTargetName);
                UpdateTargetDataGrid();
                //FlashMessage.ActivateFFXIV();
                Logging.Write(LogLevel.INFO, "Adding {0} To Target List", MudBase.LastTargetName); }
        }

        public static void UpdateTargetDataGrid()
        {
            if (Instance != null && Instance.dataGridView1 != null && Instance.dataGridView1.DataSource != null)
            {
                BindingList<StringValue> targets = (BindingList<StringValue>)Instance.dataGridView1.DataSource;
                targets.Clear();
                foreach (String s in Settings.Default.MOBS_TO_TARGET)
                {
                    targets.Add(new StringValue(s));
                }
                Instance.dataGridView1.Refresh();
            }
        }

        private void UpdateTargetSettings(object sender, EventArgs e)
        {
            if (dataGridView1 != null && dataGridView1.DataSource != null && dataGridView1.RowCount > 0)
            {
                Settings.Default.MOBS_TO_TARGET.Clear();
                foreach (StringValue sv in (BindingList<StringValue>)dataGridView1.DataSource)
                {
                    Settings.Default.MOBS_TO_TARGET.Add(sv.Name);
                }
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = ((CheckBox)sender).Checked;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if(row != dataGridView1.Rows[dataGridView1.Rows.Count-1])
                    Settings.Default.MOBS_TO_TARGET.Remove(((StringValue)row.DataBoundItem).Name);
            }
            UpdateTargetDataGrid();
            //FlashMessage.ActivateFFXIV();
            Logging.Write(LogLevel.INFO, "Removing Selection From Target List");
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.HOTKEY_MODIFIER_TOGGLE_MOVEMENT = ((ComboBox)sender).SelectedIndex;
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.HOTKEY_MODIFIER_ADD_TARGET_LIST = ((ComboBox)sender).SelectedIndex;
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.HOTKEY_MODIFIER_REM_TARGET_LIST = ((ComboBox)sender).SelectedIndex;
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            GameSettingsManager.FaceTargetOnAction = checkBox9.Checked;
        }
    }
}
