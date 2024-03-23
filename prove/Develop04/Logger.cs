using System;
using System.IO;

public class Logger
{
    private readonly string _logFilePath;

    public Logger(string logFilePath)
    {
        _logFilePath = logFilePath;
    }

    public void LogActivity(string activityName)
    {
        // Increment the count for the activity
        string logEntry = $"{DateTime.Now}: {activityName} activity performed.\n";
        File.AppendAllText(_logFilePath, logEntry);
    }

    public string ReadLog()
    {
        // Read the entire log file
        return File.ReadAllText(_logFilePath);
    }
}