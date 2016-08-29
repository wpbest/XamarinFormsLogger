using System.IO;
using Xamarin.Forms;

namespace XamarinFormsLogger
{
    static public class Logger
    {
        static public LoggingLevel Level {get; set;}
        static public string Tag { get; set; }
        static public string Message { get; set; }
        static public string ApplicationLocalStoragePath { get; set; }

        static public void SetApplicationLocalStoragePath()
        {
            ApplicationLocalStoragePath = DependencyService.Get<ILogger>().GetApplicationLocalStoragePath();
        }
        static public void Log(LoggingLevel level, string tag, string message)
        {
            Level = level;
            Tag = tag;
            Message = message;
            DependencyService.Get<ILogger>().Log(level, tag, message);
        }
        static public void Log(string tag, string message)
        {
            Tag = tag;
            Message = message;
            Log(Level, Tag, Message);
        }
        static public void Log(string message)
        {
            Message = message;
            Log(Level, Tag, Message);
        }
        static public void Log()
        {
            Log(Level, Tag, Message);
        }
        static public void Debug(string tag, string message)
        {
            Level = LoggingLevel.Debug;
            Tag = tag;
            Message = message;
            Log(Level, Tag, Message);
        }
        static public void Debug(string message)
        {
            Level = LoggingLevel.Debug;
            Message = message;
            Log(Level, Tag, Message);
        }
        static public void Info(string tag, string message)
        {
            Level = LoggingLevel.Info;
            Tag = tag;
            Message = message;
            Log(Level, Tag, Message);
        }
        static public void Info(string message)
        {
            Level = LoggingLevel.Info;
            Message = message;
            Log(Level, Tag, Message);
        }
        static public void Warn(string tag, string message)
        {
            Level = LoggingLevel.Warn;
            Tag = tag;
            Message = message;
            Log(Level, Tag, Message);
        }
        static public void Warn(string message)
        {
            Level = LoggingLevel.Warn;
            Message = message;
            Log(Level, Tag, Message);
        }
        static public void Error(string tag, string message)
        {
            Level = LoggingLevel.Error;
            Tag = tag;
            Message = message;
            Log(Level, Tag, Message);
        }
        static public void Error(string message)
        {
            Level = LoggingLevel.Error;
            Message = message;
            Log(Level, Tag, Message);
        }
        static public void Fatal(string tag, string message)
        {
            Level = LoggingLevel.Fatal;
            Tag = tag;
            Message = message;
            Log(Level, Tag, Message);
        }
        static public void Fatal(string message)
        {
            Level = LoggingLevel.Fatal;
            Message = message;
            Log(Level, Tag, Message);
        }
        static public string GetLoggingLevel (LoggingLevel level)
        {
            string loggingLevel;

            switch (level)
            {
                case LoggingLevel.Debug:
                    loggingLevel = "Debug";
                    break;
                case LoggingLevel.Info:
                    loggingLevel = "Info";
                    break;
                case LoggingLevel.Warn:
                    loggingLevel = "Warn";
                    break;
                case LoggingLevel.Error:
                    loggingLevel = "Error";
                    break;
                case LoggingLevel.Fatal:
                    loggingLevel = "Fatal";
                    break;
                default:
                    loggingLevel = "Unknown";
                    break;
            }

            return loggingLevel;
        }

        static public string GetLoggingLevel()
        {
            return GetLoggingLevel(Level);
        }

        static public string GetLoggingFilePath (string loggingfileName)
        {
            var loggingFilePath = Path.Combine(ApplicationLocalStoragePath, loggingfileName);
            return loggingFilePath;
        }
    }
}
