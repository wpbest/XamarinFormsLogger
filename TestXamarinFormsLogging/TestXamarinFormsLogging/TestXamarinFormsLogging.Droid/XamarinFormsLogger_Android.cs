
using System;
using Xamarin.Forms;
using XamarinFormsLogger;
using XamarinFormsLogger.Droid;

[assembly: Dependency(typeof(XamarinFormsLogger_Android))]
namespace XamarinFormsLogger.Droid
{
    public class XamarinFormsLogger_Android : ILogger
    {
        public XamarinFormsLogger_Android() { }

        public void Log(LoggingLevel level, string tag, string message)
        {
            switch (level)
            {
                case LoggingLevel.Debug: 
                    Android.Util.Log.Debug(tag, message);
                    break;
                case LoggingLevel.Info:
                    Android.Util.Log.Info(tag, message);
                    break;
                case LoggingLevel.Warn:
                    Android.Util.Log.Warn(tag, message);
                    break;
                case LoggingLevel.Error:
                    Android.Util.Log.Error(tag, message);
                    break;
                case LoggingLevel.Fatal:
                    Android.Util.Log.Wtf(tag, message);
                    break;
            }
        }
        public string GetApplicationLocalStoragePath()
        {
            string applicationLocalStoragePath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return applicationLocalStoragePath;
        }
    }
}