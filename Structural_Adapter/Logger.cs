using System;

namespace Structural_Adapter
{
    public class Logger : EnhancedLogger, ILogger
    {
        private readonly ILogManager<ILogContext> manager;
        public ILog Log(string message, LogLevel level = LogLevel.Info)
        {
            ILog log = new Log { LogLevel = level, Message = message };
            
            manager.WriteTo(EnhanceLog(log));
            return log;
        }
    }
}
