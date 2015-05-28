using Mud.Helpers;
using Mud.Properties;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Mud
{
    public partial class FlashMessage : Form
    {
        public enum MessageSize
        {
            TINY,
            SMALL,
            MEDIUM,
            LARGE,
            HUGE
        }

        public static FlashMessage LastMessage;
        public static int LastFFIXVPID = int.MinValue;

        private System.Windows.Forms.Timer CloseTimer;
        private System.Windows.Forms.Timer ActivateTimer;

        private FlashMessage(LogLevel Level, String Message, int IntervalSeconds, MessageSize Size)
        {
            if (LastMessage != null)
                LastMessage.Close();
            //Logging.Write(LogLevel.INFO, "Flashing Message: {0}",Message);
            InitializeComponent();
            float FontSize;
            switch (Size)
            {
                case MessageSize.TINY:      FontSize = 8f;      break;
                case MessageSize.SMALL:     FontSize = 16f;     break;
                case MessageSize.MEDIUM:    FontSize = 32f;     break;
                case MessageSize.LARGE:     FontSize = 64f;     break;
                case MessageSize.HUGE:      FontSize = 128f;    break;
                default:                    FontSize = 32f;     break;
            }
            this.label1.Font            = new Font(this.label1.Font.FontFamily, FontSize, this.label1.Font.Style);
            this.label1.Text            = Message;
            this.label1.ForeColor       = Color.FromArgb(Level.Dark.A, Level.Dark.R, Level.Dark.G, Level.Dark.B);
            this.Width                  = Screen.PrimaryScreen.WorkingArea.Width;
            this.Height                 = (int)Math.Floor(Screen.PrimaryScreen.WorkingArea.Height * 0.15);
            this.StartPosition          = FormStartPosition.CenterScreen;
            this.TopMost                = true;
            this.CloseTimer             = new System.Windows.Forms.Timer();
            this.CloseTimer.Interval    = IntervalSeconds * 1000;
            this.CloseTimer.Tick        += CloseDialog;
            this.CloseTimer.Start();
            if (Settings.Default.UI_ACTIVATE_FFXIV)
            {
                uint pid;
                GetWindowThreadProcessId(GetForegroundWindow(), out pid);
                Process p = Process.GetProcessById((int)pid);
                if (p.ProcessName.Equals("ffxiv"))
                    LastFFIXVPID = p.Id;
                this.ActivateTimer = new System.Windows.Forms.Timer();
                this.ActivateTimer.Interval = 1;
                this.ActivateTimer.Tick += ActivateFFXIV;
                this.ActivateTimer.Start();
            }
            LastMessage = this;
            this.ShowDialog();
        }

        #region Static Methods

        public static void Flash(LogLevel Level, String Message)
        {
            new Thread(new ThreadStart(() => new FlashMessage(Level, Message, 1, MessageSize.LARGE))).Start();
        }

        public static void Flash(LogLevel Level, String Message, MessageSize Size)
        {
            new Thread(new ThreadStart(() => new FlashMessage(Level, Message, 1, Size))).Start();
        }

        public static void ActivateFFXIV()
        {
            if (Settings.Default.UI_ACTIVATE_FFXIV && LastFFIXVPID != int.MinValue)
            {
                Process p = Process.GetProcessById(LastFFIXVPID);
                if (p != null)
                {
                    //Logging.Write(LogLevel.INFO, "Activating FFXIV: {0}", p.Id);
                    SetForegroundWindow(p.MainWindowHandle);
                }
            }
        }

        #endregion Static Methods

        #region Custom Methods

        void CloseDialog(object sender, EventArgs e)
        {
            this.CloseTimer.Stop();
            this.Close();
        }

        void ActivateFFXIV(object sender, EventArgs e)
        {
            this.ActivateTimer.Stop();
            ActivateFFXIV();
        }

        #endregion Custom Methods

        #region DLL Imports

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowThreadProcessId(IntPtr hWnd, out uint ProcessId);

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        #endregion DLL Imports
    }
}
