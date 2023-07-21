namespace Factory_Pattern_Exercise;

public interface ICustomLogger
{
    public void Trace();
    public void Debug();
    public void Information();
    public void Warning();
    public void Error();
    public void Critical();
}