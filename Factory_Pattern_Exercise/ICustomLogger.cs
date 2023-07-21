namespace Factory_Pattern_Exercise;

public interface ICustomLogger
{
    public void Trace(string logMessage);
    public void Debug(string logMessage);
    public void Information(string logMessage);
    public void Warning(string logMessage);
    public void Error(string logMessage);
    public void Critical(string logMessage);
}