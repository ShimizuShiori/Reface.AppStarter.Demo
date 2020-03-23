using Reface.AppStarter.AppContainers;
using Reface.AppStarter.Demo.Users.Commands;
using Reface.CommandBus;
using System;

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
                #region 验证 app.json 配置文件

                /**
                 * 验证 app.json 是否成功加载到 <see cref="Reface.AppStarter.Demo.Users.Configs.UsersConfig"/> 上
                 * 如果加载成功，则下面的代码不会抛出异常
                 */

                ICommandBus commandBus = scope.CreateComponent<ICommandBus>();
                string userId = commandBus.Dispatch<RegisterUserCommand, string>(new RegisterUserCommand()
                {
                    Name = "admin",
                    Password = "123456"
                });
                Console.WriteLine($"注册成功，用户 ID = {userId}");

                #endregion

                #region 验证事件总线

                string userName = app.Context.GetOrCreate("UserName", key => "");
                Console.WriteLine($"OK , IC , Your name is {userName}");

                #endregion
            }
            Console.ReadLine();
        }
    }
}
