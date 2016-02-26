using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_12
{
    class DateTimeLogger: ILogger
    {
        public List<string> LogPosts { get; private set; }

        public DateTimeLogger()
        {
            LogPosts = new List<string>();
        }

        public void Log(string message)
        {
            DateTime CurrentTimeToLog = DateTime.Now;
            LogPosts.Add(message + $" | Date and time: {CurrentTimeToLog.ToString()}");
        }
    }
}
