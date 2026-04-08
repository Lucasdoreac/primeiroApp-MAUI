using System.IO;

namespace appUsandoFlyoutPage;

public static class Logger
{
    private static readonly string LogFile = @"C:\temp\appUsandoFlyoutPage.log";

    static Logger()
    {
        try
        {
            Directory.CreateDirectory(@"C:\temp");
        }
        catch { }
    }

    public static void Log(string message)
    {
        try
        {
            File.AppendAllText(LogFile, $"[{DateTime.Now:HH:mm:ss.fff}] {message}\n");
        }
        catch { }
    }

    public static void LogException(Exception ex)
    {
        Log($"EXCEPTION: {ex.GetType().Name}");
        Log($"Message: {ex.Message}");
        Log($"Stack: {ex.StackTrace}");
        if (ex.InnerException != null)
        {
            Log($"Inner: {ex.InnerException.Message}");
        }
    }
}
