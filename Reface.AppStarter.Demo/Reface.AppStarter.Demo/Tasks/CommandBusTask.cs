using Reface.AppStarter.Attributes;
using Reface.AppStarter.Demo.Users.Commands;
using Reface.CommandBus;
using System;

namespace Reface.AppStarter.Demo.Tasks
{
    [Component]
    public class CommandBusTask : ITask
    {
        public string TaskName => "命令总线任务";

        private readonly ICommandBus commandBus;

        public CommandBusTask(ICommandBus commandBus)
        {
            this.commandBus = commandBus;
        }

        public void Do()
        {
            /**
             * 验证 app.json 是否成功加载到 <see cref="Reface.AppStarter.Demo.Users.Configs.UsersConfig"/> 上
             * 如果加载成功，则下面的代码不会抛出异常
             */

            string userId = commandBus.Dispatch<RegisterUserCommand, string>(new RegisterUserCommand()
            {
                Name = "admin",
                Password = "123456"
            });
            Console.WriteLine($"注册成功，用户 ID = {userId}");
        }
    }
}
