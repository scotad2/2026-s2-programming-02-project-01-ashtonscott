using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal static class ConsoleDebugger
    {
        public static bool Enabled { get; set; } = true;

        public enum LogType
        {
            Info,
            Debug,
            Error
        }

        private static string GetColour(LogType type)
        {
            return type switch
            {
                LogType.Info => "\u001b[32m",
                LogType.Debug => "\u001b[36m",
                LogType.Error => "\u001b[31m",
                _ => "\u001b[0m",
            };
        }

        public static void Log(string message, LogType type)
        {
            if (Enabled)
            {
                string colour = GetColour(type);
                string reset = "\u001b[0m";

                Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] [{colour}{type}{reset}] {message}");
            }
        }
    }
}
