namespace Structural_Adapter
{
    public interface ILogger
    {
        ILog Log(string message, LogLevel level = LogLevel.Info);
    }
}