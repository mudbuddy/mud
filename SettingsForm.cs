using ff14bot;
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
            ReloadSettings();
            DataGridViewColumn column = dataGridView1.Columns[0];
            column.Width = dataGridView1.Width - 45;
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
            comboBox1.SelectedIndex = Properties.Settings.Default.HOTKEY_PAUSE_MODIFIER;
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(MudBase.ModifierKeyStrings);
            comboBox2.SelectedIndex = Properties.Settings.Default.HOTKEY_TARGET_MODE_MODIFIER;
            comboBox3.Items.Clear();
            comboBox3.Items.AddRange(MudBase.TargetingModes);
            SelectTargetingMode(Properties.Settings.Default.SELECTED_TARGETING_MODE);
            comboBox4.Items.Clear();
            comboBox4.Items.AddRange(MudBase.TargetListTypes);
            comboBox4.SelectedIndex = Properties.Settings.Default.SELECTED_TARGET_LIST_TYPE;
            comboBox5.Items.Clear();
            comboBox5.Items.AddRange(MudBase.MoveTarget);
            comboBox5.SelectedIndex = Properties.Settings.Default.SELECTED_MOVE_TARGET;
            UpdateTargetDataGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateTargetSettings(sender, e);
            Properties.Settings.Default.Save();
            MudBase.ResetHotkeys();
            Logging.Write(LogLevel.WARNING, "Settings Saved & Updated!");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Logging.Write(LogLevel.WARNING, "Settings RESET!");
            Properties.Settings.Default.Reset();
            ReloadSettings();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.HOTKEY_PAUSE_MODIFIER = ((ComboBox)sender).SelectedIndex;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.HOTKEY_TARGET_MODE_MODIFIER = ((ComboBox)sender).SelectedIndex;
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
            if (Core.Player.HasTarget && Core.Player.CurrentTarget is Character)
            {
                Settings.Default.TARGET_MOB_LIST.Add(Core.Player.CurrentTarget.Name);
                UpdateTargetDataGrid();
            }
        }

        private void UpdateTargetDataGrid()
        {
            BindingList<StringValue> targets = new BindingList<StringValue>();
            foreach (String s in Settings.Default.TARGET_MOB_LIST)
            {
                targets.Add(new StringValue(s));
            }
            dataGridView1.DataSource = targets;
        }

        private void UpdateTargetSettings(object sender, EventArgs e)
        {
            Settings.Default.TARGET_MOB_LIST.Clear();
            foreach (StringValue sv in (BindingList<StringValue>)dataGridView1.DataSource)
            {
                Settings.Default.TARGET_MOB_LIST.Add(sv.MobName);
            }
        }
    }
}
