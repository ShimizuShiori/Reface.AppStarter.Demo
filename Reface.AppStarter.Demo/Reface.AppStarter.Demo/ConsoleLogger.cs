using Reface.AppStarter.Demo.Logger;
using System;

namespace Reface.AppStarter.Demo
{
    public class ConsoleLogger : ILogger
    {
        public void Output(LoggerLevel level, string content)
        {
            var color = Console.ForegroundColor;
            switch (level)
            {
                case LoggerLevel.Info:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case LoggerLevel.Warning:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case LoggerLevel.Error:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                default:
                    break;
            }
            Console.WriteLine($"{DateTime.Now.ToString("HH:mm:ss.fff")} [{level.ToString()}] - {content}");
            Console.ForegroundColor = color;
        }
    }
}
