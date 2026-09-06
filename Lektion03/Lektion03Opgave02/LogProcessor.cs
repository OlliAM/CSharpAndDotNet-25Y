namespace Lektion03Opgave02;

public class LogProcessor
{
    public delegate void LogHandler(string log, DateTime dateTime);
    
    public void ProcessLogs(string[] logs, LogHandler handler)
    {
        foreach (var log in logs)
        {
            // Delegaten kaldes her med en streng og et DateTime-objekt
            handler(log, DateTime.Now);
        }
    }
}