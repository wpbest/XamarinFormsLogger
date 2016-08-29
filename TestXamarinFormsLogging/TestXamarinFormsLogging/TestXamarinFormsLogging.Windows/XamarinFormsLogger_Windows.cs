using Xamarin.Forms;
using XamarinFormsLogger;
using XamarinFormsLogger.Windows;
using System.Diagnostics;
using Windows.Storage;

[assembly: Dependency(typeof(XamarinFormsLogger_Windows))]
namespace XamarinFormsLogger.Windows
{
    public class XamarinFormsLogger_Windows : ILogger
    {
        public XamarinFormsLogger_Windows() { }

        public void Log(LoggingLevel level, string tag, string message)
        {
            Debug.WriteLine(XamarinFormsLogger.Logger.GetLoggingLevel(level) + " " + tag + " " + message);
        }
        public string GetApplicationLocalStoragePath()
        {
            string applicationLocalStoragePath = ApplicationData.Current.LocalFolder.Path;
            return applicationLocalStoragePath;

        }

    }
}
