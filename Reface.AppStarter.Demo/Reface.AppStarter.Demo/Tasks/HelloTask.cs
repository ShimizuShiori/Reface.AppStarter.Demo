using Reface.AppStarter.Attributes;
using System;
using System.Threading.Tasks;

namespace Reface.AppStarter.Demo.Tasks
{
    /// <summary>
    /// 一个任务，int.MinValue 会保证它被第一个执行
    /// </summary>
    [Task("Hello", int.MinValue)]
    public class HelloTask : ITaskExecutor
    {
        public void Execute()
        {
            Console.WriteLine("Hello");
        }
    }
}
