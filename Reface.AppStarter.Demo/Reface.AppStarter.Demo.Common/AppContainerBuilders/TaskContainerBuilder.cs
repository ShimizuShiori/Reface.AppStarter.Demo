using Reface.AppStarter.AppContainers;
using Reface.AppStarter.Attributes;
using Reface.AppStarter.Demo.Tasks;
using System.Collections.Generic;

namespace Reface.AppStarter.AppContainerBuilders
{
    public class TaskContainerBuilder : IAppContainerBuilder
    {
        private readonly ICollection<TaskInfo> taskInfos;

        public TaskContainerBuilder()
        {
            this.taskInfos = new List<TaskInfo>();
        }

        public void AddTask(AttributeAndTypeInfo info)
        {
            if (!(info.Attribute is TaskAttribute taskatt)) return;
            if (!typeof(ITaskExecutor).IsAssignableFrom(info.Type)) return;
            this.taskInfos.Add(new TaskInfo()
            {
                TaskAttribute = taskatt,
                TaskType = info.Type
            });
        }

        public IAppContainer Build(AppSetup setup)
        {
            return new TaskContainer(this.taskInfos);
        }

        public void Prepare(AppSetup setup)
        {
            var builder = setup.GetAppContainerBuilder<AutofacContainerBuilder>();
            builder.Building += Builder_Building;
        }

        private void Builder_Building(object sender, AppContainerBuilderBuildEventArgs e)
        {
            var builder = (AutofacContainerBuilder)sender;
            this.taskInfos.ForEach(info =>
            {
                builder.Register(info.TaskType, RegistionMode.AsSelf);
            });
        }
    }
}
