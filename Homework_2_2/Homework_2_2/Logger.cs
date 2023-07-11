using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_2
{
    internal class Logger
    {
        private static readonly Logger instance = new Logger();

        public string AllLogs { get; set; }

        static Logger()
        { 
        }

        private Logger() 
        {
        }

        public static Logger Instance
        { 
            get { return instance; }
        }

        public void LogInfo(LogType type, string message)
        {
            string buf = $"{DateTime.Now.ToString()}\t{type}\t{message}{Environment.NewLine}";
            Console.WriteLine($"{buf}");
            AllLogs += buf ;
        }
    }
}
