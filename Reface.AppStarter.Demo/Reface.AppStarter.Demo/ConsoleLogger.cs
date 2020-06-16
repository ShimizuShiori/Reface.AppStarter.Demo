using Reface.AppStarter.Demo.Logger;
using System;

namespace Reface.AppStarter.Demo
{
    /// <summary>
    /// 重写原有的 <see cref="ILogger"/> 组件，让其在控制台中输出。
    /// 并且对不同的消息有不同的颜色。
    /// 此类型用于演示如何替换一个已有的组件。
    /// 替换的代码在 <see cref="DemoAppModule.GetLogger"/> 中
    /// </summary>
    public class ConsoleLogger : ILogger
    {
        public void NewLine()
        {
            Console.WriteLine();
        }

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
                case LoggerLevel.Message:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                default:
                    break;
            }
            Console.WriteLine($"{DateTime.Now.ToString("HH:mm:ss.fff")} [{level.ToString()}] - {content}");
            Console.ForegroundColor = color;
        }
    }
}
