using Reface.AppStarter.Attributes;
using Reface.EventBus;
using System;

namespace Reface.AppStarter.Demo.Tasks
{
    [Component]
    public class EventBusTask : ITask
    {
        public string TaskName => "事件总线任务";

        private readonly IEventBus eventBus;
        private readonly App app;

        public EventBusTask(IEventBus eventBus, App app)
        {
            this.eventBus = eventBus;
            this.app = app;
        }

        public void Do()
        {
            string userName = app.Context.GetOrCreate("UserName", key => "");
            Console.WriteLine($"OK , IC , Your name is {userName}");
        }
    }
}
