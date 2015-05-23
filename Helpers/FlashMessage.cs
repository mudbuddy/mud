using MudBase.Helpers;
using MudBase.Properties;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace MudBase
{
    public partial class FlashMessage : Form
    {
        public static void Flash(LogLevel Level, String Message)
        {
            new Thread(new ThreadStart(() => new FlashMessage(Level, Message, 1))).Start();
        }

        private System.Windows.Forms.Timer CloseTimer;
        private System.Windows.Forms.Timer ActivateTimer;
        private FlashMessage(LogLevel Level, String Message, int IntervalSeconds)
        {
            //Logging.Write(LogLevel.PRIMARY, "FlashMessage: {0}",Message);
            InitializeComponent();
            this.label1.Text = Message;
            this.label1.ForeColor = Color.FromArgb(Level.dark.A, Level.dark.R, Level.dark.G, Level.dark.B);
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Height = (int)Math.Floor(Screen.PrimaryScreen.WorkingArea.Height * 0.15);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.CloseTimer = new System.Windows.Forms.Timer();
            this.CloseTimer.Interval = IntervalSeconds * 1000;
            this.CloseTimer.Tick += CloseDialog;
            this.CloseTimer.Start();
            if (Settings.Default.ACTIVATE_FFXIV) {
                this.ActivateTimer = new System.Windows.Forms.Timer();
                this.ActivateTimer.Interval = 1;
                this.ActivateTimer.Tick += ActivateFFXIV;
                this.ActivateTimer.Start(); }
            this.ShowDialog();
        }

        void CloseDialog(object sender, EventArgs e)
        {
            this.CloseTimer.Stop();
            this.Close();
        }

        void ActivateFFXIV(object sender, EventArgs e)
        {
            this.ActivateTimer.Stop();
            Process[] p = Process.GetProcessesByName("ffxiv");
            //Logging.Write(LogLevel.PRIMARY, "Activating FFXIV: {0} processes",p.Length);
            if (p.Length > 0)
                SetForegroundWindow(p[0].MainWindowHandle);
        }

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);
    }
}
