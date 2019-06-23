using System;

namespace Structural_Adapter
{
    public interface ILog
    {
        string Message { get; set; }

        LogLevel LogLevel { get; set; }

        bool HasError { get; set; }

        DateTime Date { get; set; } 
    }

    public class Log: ILog
    {
        public string Message { get; set; }

        public LogLevel LogLevel { get; set; }

        public bool HasError { get; set; }
        public DateTime Date { get; set; }
    }
}