using System;

namespace DiscordBot
{
    public class Debug
    {
        private enum LogLevel
        {
            Info,
            Warning,
            Error,
        }
        public static void Log(string message)
        {
            Print(LogLevel.Info, message);
        }

        public static void LogFormat(string message, params object[] args)
        {
            Log(string.Format(message, args));
        }

        public static void LogWarning(string message)
        {
            Print(LogLevel.Warning, message);
        }

        public static void LogWarningFormat(string message, params object[] args)
        {
            LogWarning(string.Format(message, args));
        }

        public static void LogError(string message)
        {
            Print(LogLevel.Error, message);
        }

        public static void LogErrorFormat(string message, params object[] args)
        {
            LogError(string.Format(message, args));
        }

        private static void Print(LogLevel level, string message)
        {
            Console.WriteLine($"[{nameof(level)}] {message}");
        }
    }
}
