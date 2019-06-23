using System;

namespace Structural_Adapter
{
    public class EnhancedLogger
    {
        public ILog EnhanceLog(ILog log)
        {
            log.Date = DateTime.UtcNow;

            return log;
        }
    }
}