using System.Diagnostics;
using Xamarin.Forms;
using XamarinFormsLogger;
using XamarinFormsLogger.WinPhone;

[assembly: Dependency(typeof(XamarinFormsLogger_WinPhone))]
namespace XamarinFormsLogger.WinPhone
{
    public class XamarinFormsLogger_WinPhone : ILogger
    {
        public XamarinFormsLogger_WinPhone() { }

        public void Log(LoggingLevel level, string tag, string message)
        {
            Debug.WriteLine(XamarinFormsLogger.Logger.GetLoggingLevel(level) + " " + tag + " " + message);
        }
        public string GetApplicationLocalStoragePath()
        {
            string applicationLocalStoragePath = Windows.Storage.ApplicationData.Current.LocalFolder.Path;
            return applicationLocalStoragePath;
        }

    }
}
