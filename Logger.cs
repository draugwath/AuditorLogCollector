using System;
using System.IO;

public static class Logger
{
    private static readonly string logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "app.log");

    public static void Log(string message)
    {
        try
        {
            using (StreamWriter sw = new StreamWriter(logFilePath, true))
            {
                sw.WriteLine($"{DateTime.Now}: {message}");
            }
        }
        catch (Exception ex)
        {
            // Handle any exceptions that occur when writing to the log file
            // For simplicity, we're just ignoring them here
        }
    }
}
