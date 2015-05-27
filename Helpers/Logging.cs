using System;
using System.Windows.Media;

namespace MudBase.Helpers
{
    public class LogLevel 
    {
        public static LogLevel PRIMARY = new LogLevel(Color.FromRgb(0x33,0xb5,0xe5), Color.FromRgb(0x00,0x99,0xcc));
        public static LogLevel INFO    = new LogLevel(Color.FromRgb(0xaa,0x66,0xcc), Color.FromRgb(0x99,0x33,0xcc));
        public static LogLevel SUCCESS = new LogLevel(Color.FromRgb(0x99,0xcc,0x00), Color.FromRgb(0x66,0x99,0x00));
        public static LogLevel WARNING = new LogLevel(Color.FromRgb(0xff,0xbb,0x33), Color.FromRgb(0xff,0x88,0x00));
        public static LogLevel DANGER  = new LogLevel(Color.FromRgb(0xff,0x44,0x44), Color.FromRgb(0xcc,0x00,0x00));

        public Color Light { get; private set; }
        public Color Dark  { get; private set; }

        public LogLevel(Color light, Color dark) {
            this.Light = light;
            this.Dark  = dark;
        } 
    }

    public class Logging
    {
        public static void Write(LogLevel level, String message, params object[] args)
        {
            ff14bot.Helpers.Logging.Write(level.Light,"[MUD] " + message, args);
        }

        public static void Write(String message, params object[] args)
        {
            Write(LogLevel.INFO, message, args);
        }
    }
}
