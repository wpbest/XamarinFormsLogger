using System;
using Xamarin.Forms;
using XamarinFormsLogger;
using XamarinFormsLogger.iOS;

[assembly: Dependency(typeof(XamarinFormsLogger_iOS))]

namespace XamarinFormsLogger.iOS
{
    public class XamarinFormsLogger_iOS : ILogger
    {
        public XamarinFormsLogger_iOS() { }

        public void Log(LoggingLevel level, string tag, string message)
        {
            System.Console.WriteLine(XamarinFormsLogger.Logger.GetLoggingLevel(level) + " " + tag + " " + message);
        }
        public string GetApplicationLocalStoagePath()
        {
            string applicationLocalStoragePath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return applicationLocalStoragePath;
        }

    }
}
