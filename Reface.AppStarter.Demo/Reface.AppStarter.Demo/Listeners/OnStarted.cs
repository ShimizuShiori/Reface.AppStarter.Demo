using Reface.AppStarter.Attributes;
using Reface.AppStarter.Demo.Users;
using Reface.AppStarter.Events;
using Reface.EventBus;
using System;

namespace Reface.AppStarter.Demo.Listeners
{
    /// <summary>
    /// 当应用程序启动后的事件监听
    /// </summary>
    [Component]
    public class OnStarted : IEventListener<AppStartedEvent>
    {
        private readonly IUserService userService;

        /// <summary>
        /// 注入组件
        /// </summary>
        /// <param name="userService"></param>
        public OnStarted(IUserService userService)
        {
            this.userService = userService;
        }

        public void Handle(AppStartedEvent @event)
        {
            bool success = this.userService.CheckUserNameAndPassword(new User()
            {
                Name = "admin",
                Password = "888888"
            });
            Console.WriteLine(success);
        }
    }
}
