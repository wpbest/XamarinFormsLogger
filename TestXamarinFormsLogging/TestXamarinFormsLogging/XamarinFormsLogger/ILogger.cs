namespace XamarinFormsLogger
{
    public enum LoggingLevel
    {
        Debug,
        Info,
        Warn,
        Error,
        Fatal
    }
    public interface ILogger
    {
        void Log(LoggingLevel level, string tag, string message);
        string GetApplicationLocalStoragePath();
    }
}
