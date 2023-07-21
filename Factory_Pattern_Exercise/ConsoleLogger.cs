namespace Factory_Pattern_Exercise;

public class ConsoleLogger : ICustomLogger
{
    public void Trace(string logMessage)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"Trace:\t {DateTime.Now} - {logMessage}");
        Console.ForegroundColor = ConsoleColor.Gray;
    }

    public void Debug(string logMessage)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Debug:\t {DateTime.Now} - {logMessage}");
        Console.ForegroundColor = ConsoleColor.Gray;
    }

    public void Information(string logMessage)
    {   
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"Information:\t {DateTime.Now} - {logMessage}");
        Console.ForegroundColor = ConsoleColor.Gray;    
    }

    public void Warning(string logMessage)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Warning:\t {DateTime.Now} - {logMessage}");
        Console.ForegroundColor = ConsoleColor.Gray;
    }

    public void Error(string logMessage)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine($"Error:\t {DateTime.Now} - {logMessage}");
        Console.ForegroundColor = ConsoleColor.Gray;
    }

    public void Critical(string logMessage)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine($"Critical:\t {DateTime.Now} - {logMessage}");
        Console.ForegroundColor = ConsoleColor.Gray;        
    }
}
