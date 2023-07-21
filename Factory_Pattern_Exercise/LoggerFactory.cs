namespace Factory_Pattern_Exercise;

public static class LoggerFactory
{
    public static ICustomLogger CreateLogger(string logType)
    {
        return logType.ToLower() switch
        {
            "console" => new ConsoleLogger(),
            "file" => new FileLogger(),
            "database" => new DatabaseLogger(),
            _ => new ConsoleLogger(),
        };
    }
}
