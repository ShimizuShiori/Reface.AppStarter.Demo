using Reface.AppStarter.Attributes;
using System;
using System.Diagnostics;

namespace Reface.AppStarter.Demo.Logger
{
    [Component]
    public class DefaultLogger : ILogger
    {
        public void NewLine()
        {
            Debug.WriteLine("");
        }

        public void Output(LoggerLevel level, string content)
        {
            Debug.WriteLine($"{DateTime.Now.ToString("HH:mm:ss.fff")} [{level.ToString()}] - {content}");
        }
    }
}
