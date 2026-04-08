using System;
using System.IO;

namespace appUsandoFlyoutPage;

public static class ConsoleLogger
{
    private static readonly string LogFile = @"C:\temp\flyoutpage.log";

    static ConsoleLogger()
    {
        try { Directory.CreateDirectory(@"C:\temp"); } catch { }
    }

    public static void Log(string message)
    {
        try
        {
            var msg = $"[{DateTime.Now:HH:mm:ss.fff}] {message}";
            Console.WriteLine(msg);
            File.AppendAllText(LogFile, msg + Environment.NewLine);
        }
        catch { }
    }

    public static void LogException(Exception ex)
    {
        Log($"EXCEPTION: {ex.GetType().Name}");
        Log($"Message: {ex.Message}");
        Log($"Stack: {ex.StackTrace}");
        if (ex.InnerException != null)
            Log($"Inner: {ex.InnerException.Message}");
    }
}
