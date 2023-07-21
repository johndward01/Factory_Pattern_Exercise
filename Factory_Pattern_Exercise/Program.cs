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