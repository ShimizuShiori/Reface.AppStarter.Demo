using Reface.AppStarter.AppContainers;
using Reface.AppStarter.Demo.Users.Commands;
using Reface.CommandBus;
using System;
using System.Collections.Generic;

namespace Reface.AppStarter.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // 应用程序安装类
            AppSetup setup = new AppSetup();

            // 启动示例模块
            var app = setup.Start(new DemoAppModule());

            // 创建 Autofac 容器
            var container = app.GetAppContainer<AutofacContainerComponentContainer>();

            // 开启 Scope
            using (var scope = container.BeginScope("TEST"))
            {
                IEnumerable<ITask> tasks = scope.CreateComponent<IEnumerable<ITask>>();
                foreach (var task in tasks)
                {
                    Console.WriteLine($"开始任务 [{task.TaskName}]");
                    try
                    {
                        task.Do();
                        Console.WriteLine("任务完成");
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine($"任务异常 [{ex.Message}]");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
