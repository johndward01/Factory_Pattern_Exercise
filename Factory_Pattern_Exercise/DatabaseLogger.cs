using Dapper;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

namespace Factory_Pattern_Exercise;

internal class DatabaseLogger : ICustomLogger
{
    private readonly MySqlConnection _mysqlConnection = new(GetDBConnectionString());

    private static string GetDBConnectionString()
    {
        var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
        return config.GetConnectionString("factory_pattern");
    }

    public void Trace(string logMessage)
    {
        _mysqlConnection.Execute("INSERT INTO factory_pattern.logs (Level, DateTime, Message) VALUES (@level, @dateTime, @message);",
            new {level = "Trace", dateTime = DateTime.UtcNow.ToString(), message = logMessage});
    }

    public void Debug(string logMessage)
    {
        _mysqlConnection.Execute("INSERT INTO factory_pattern.logs (Level, DateTime, Message) VALUES (@level, @dateTime, @message);",
            new { level = "Debug", dateTime = DateTime.UtcNow.ToString(), message = logMessage });
    }

    public void Information(string logMessage)
    {
        _mysqlConnection.Execute("INSERT INTO factory_pattern.logs (Level, DateTime, Message) VALUES (@level, @dateTime, @message);",
            new { level = "Information", dateTime = DateTime.UtcNow.ToString(), message = logMessage });
    }

    public void Warning(string logMessage)
    {
        _mysqlConnection.Execute("INSERT INTO factory_pattern.logs (Level, DateTime, Message) VALUES (@level, @dateTime, @message);",
            new { level = "Warning", dateTime = DateTime.UtcNow.ToString(), message = logMessage });
    }

    public void Error(string logMessage)
    {
        _mysqlConnection.Execute("INSERT INTO factory_pattern.logs (Level, DateTime, Message) VALUES (@level, @dateTime, @message);",
            new { level = "Error", dateTime = DateTime.UtcNow.ToString(), message = logMessage });
    }

    public void Critical(string logMessage)
    {
        _mysqlConnection.Execute("INSERT INTO factory_pattern.logs (Level, DateTime, Message) VALUES (@level, @dateTime, @message);",
            new { level = "Critical", dateTime = DateTime.UtcNow.ToString(), message = logMessage });
    }
}