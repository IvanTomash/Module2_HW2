using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_2
{
    internal class NotificationSystem
    {
        private readonly Logger _logger;
        public NotificationSystem(Logger logger)
        {
            _logger = logger;
        }

        public void Notify(NotifyType type, string message, string destination)
        {
            string buf = $"Customer was notified by {type} {destination}:\n{message}";
            _logger.LogInfo(LogType.Info, buf);
        }
    }
}
