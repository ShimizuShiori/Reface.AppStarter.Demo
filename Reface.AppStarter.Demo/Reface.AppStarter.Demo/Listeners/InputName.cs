using Reface.AppStarter.Attributes;
using Reface.AppStarter.Events;
using Reface.EventBus;
using System;

namespace Reface.AppStarter.Demo.Listeners
{
    /// <summary>
    /// 当应用程序启动后的事件监听
    /// </summary>
    [Listener]
    public class InputName : IEventListener<AppStartedEvent>
    {
        private readonly App app;

        public InputName(App app)
        {
            this.app = app;
        }

        public void Handle(AppStartedEvent @event)
        {
            Console.Write("Hello , would you like to tell me your name ? ");
            string name = Console.ReadLine();
            this.app.Context["UserName"] = name;
        }
    }
}
