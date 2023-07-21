namespace Factory_Pattern_Exercise;

internal class FileLogger : ICustomLogger
{
    readonly string _path = @"C:\Users\johnd\Desktop\Factory_Pattern_Exercise\Factory_Pattern_Exercise\LogFile.txt";

    public void Trace(string logMessage)
    {
        File.AppendAllText(_path, $"Trace:\t {DateTime.Now} - {logMessage}\n");
    }

    public void Debug(string logMessage)
    {
        File.AppendAllText(_path, $"Debug:\t {DateTime.Now} - {logMessage}\n");
    }

    public void Information(string logMessage)
    {
        File.AppendAllText(_path, $"Information:\t {DateTime.Now} - {logMessage}\n");
    }

    public void Warning(string logMessage)
    {
        File.AppendAllText(_path, $"Warning:\t {DateTime.Now} - {logMessage}\n");
    }
        
    public void Error(string logMessage)
    {
        File.AppendAllText(_path, $"Error:\t {DateTime.Now} - {logMessage}\n");
    }

    public void Critical(string logMessage)
    {
        File.AppendAllText(_path, $"Critical:\t {DateTime.Now} - {logMessage}\n");
    }
}