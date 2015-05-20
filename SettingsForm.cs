using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MudBase
{
    public partial class SettingsForm : Form
    {
        private static SettingsForm instance;
        public SettingsForm()
        {
            InitializeComponent();
            instance = this;
            comboBox1.Items.AddRange(MudBase.ModifierKeyStrings);
            comboBox1.SelectedIndex = Properties.Settings.Default.HOTKEY_PAUSE_MODIFIER;
            comboBox2.Items.AddRange(MudBase.ModifierKeyStrings);
            comboBox2.SelectedIndex = Properties.Settings.Default.HOTKEY_TARGET_MODE_MODIFIER;
            comboBox3.Items.AddRange(MudBase.TargetingModes);
            SelectTargetingMode(Properties.Settings.Default.SELECTED_TARGETING_MODE);
            comboBox4.Items.AddRange(MudBase.TargetListTypes);
            comboBox4.SelectedIndex = Properties.Settings.Default.SELECTED_TARGET_LIST_TYPE;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            MudBase.ResetHotkeys();
            MudBase.TargetMobList = Properties.Settings.Default.TARGET_MOB_LIST.Split('\n').ToList();
            Logging.Write(LogLevel.WARNING, "Settings Saved & Updated!");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Logging.Write(LogLevel.WARNING, "Settings RESET!");
            Properties.Settings.Default.Reset();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.HOTKEY_PAUSE_MODIFIER = ((ComboBox)sender).SelectedIndex;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.HOTKEY_TARGET_MODE_MODIFIER = ((ComboBox)sender).SelectedIndex;
        }

        public static void SelectTargetingMode(int p)
        {
            instance.comboBox3.SelectedIndex = p;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.SELECTED_TARGETING_MODE = ((ComboBox)sender).SelectedIndex;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.SELECTED_TARGET_LIST_TYPE = ((ComboBox)sender).SelectedIndex;
        }
    }
}
