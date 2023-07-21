using Factory_Pattern_Exercise;
// TODO: Create a static class called LoggerFactory
// TODO: Inside of the LoggerFactory class, create a method called CreateLogger() with a string parameter
//       that returns the correct instance of an ICustomLogger 

// TODO: Create an Interface called ICustomLogger
// TODO: Inside of the interface, create 6 methods
//                  LOG LEVELS
//          - Trace(string logMessage);
//          - Debug(string logMessage);
//          - Information(string logMessage);
//          - Warning(string logMessage);
//          - Error(string logMessage);
//          - Critical(string logMessage);

// TODO: Use this Template for your methods (Log Message Template: Log Level Name, Date/Time, logMessage)
// TODO: Create a class called ConsoleLogger that implements the ICustomLogger interface
// TODO: Create a class called FileLogger that implements the ICustomLogger interface 
//       (Create a file in the root of your project called LogFile.txt, right-click the file, copy the path, and use that with the File.AppendAllText() method)
// Bonus: Create a class called DatabaseLogger that implements the ICustomLogger interface 
//        (Use the dapper exercise to help you implement this)


// TODO: Use the LoggerFactory to create each type of custom logger and then write 1 log foreach of the LOG LEVELS creatively

var consoleLogger = LoggerFactory.CreateLogger("console");
consoleLogger.Trace("This is a Trace log message");
consoleLogger.Debug("This is a Debug log message");
consoleLogger.Information("This is an Information log message");
consoleLogger.Warning("This is a Warning log message");
consoleLogger.Error("This is an Error log message");
consoleLogger.Critical("This is a Critical log message");

var fileLogger = LoggerFactory.CreateLogger("file");
fileLogger.Trace("This is a Trace log message");
fileLogger.Debug("This is a Debug log message");
fileLogger.Information("This is an Information log message");
fileLogger.Warning("This is a Warning log message");
fileLogger.Error("This is an Error log message");
fileLogger.Critical("This is a Critical log message");

var dbLogger = LoggerFactory.CreateLogger("db");
dbLogger.Trace("This is a Trace log message");
dbLogger.Debug("This is a Debug log message");
dbLogger.Information("This is an Information log message");
dbLogger.Warning("This is a Warning log message");
dbLogger.Error("This is an Error log message");
dbLogger.Critical("This is a Critical log message");