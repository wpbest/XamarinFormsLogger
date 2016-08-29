using System.Diagnostics;
using Xamarin.Forms;
using XamarinFormsLogger;
using XamarinFormsLogger.UWP;

[assembly: Dependency(typeof(XamarinFormsLogger_UWP))]
namespace XamarinFormsLogger.UWP
{
    class XamarinFormsLogger_UWP : ILogger
    {
        public XamarinFormsLogger_UWP() { }

        public void Log(LoggingLevel level, string tag, string message)
        {
            Debug.WriteLine(XamarinFormsLogger.Logger.GetLoggingLevel(level) + " " + tag + " " + message);
        }
        public string GetApplicationLocalStoragePath()
        {
            string applicationLocalPath = Windows.Storage.ApplicationData.Current.LocalFolder.Path;
            return applicationLocalPath;
        }
    }
}
