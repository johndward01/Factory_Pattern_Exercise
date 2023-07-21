namespace Factory_Pattern_Exercise;

public class ConsoleLogger : ICustomLogger
{
    public void Trace(string logMessage)
    {
        Console.WriteLine($"Information: {DateTime.Now} {logMessage}");
    }

    public void Debug(string logMessage)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Information: {DateTime.Now} {logMessage}");
    }

    public void Information(string logMessage)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"Information: {DateTime.Now} {logMessage}");        
    }

    public void Warning(string logMessage)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Information: {DateTime.Now} {logMessage}");
    }

    public void Error(string logMessage)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine($"Information: {DateTime.Now} {logMessage}");
    }

    public void Critical(string logMessage)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Information: {DateTime.Now} {logMessage}");
    }





}
