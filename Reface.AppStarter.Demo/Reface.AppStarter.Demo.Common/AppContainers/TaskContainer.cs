using Reface.AppStarter.Demo.Logger;
using Reface.AppStarter.Demo.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Reface.AppStarter.AppContainers
{
    public class TaskContainer : BaseAppContainer
    {
        private readonly IEnumerable<TaskInfo> taskInfos;

        public TaskContainer(IEnumerable<TaskInfo> taskInfos)
        {
            this.taskInfos = taskInfos.OrderBy(x => x.TaskAttribute.Order);
        }

        public override void OnAppStarted(App app)
        {
            using (var work = app.BeginWork("DoTask"))
            {
                ILogger logger = work.CreateComponent<ILogger>();
                taskInfos.ForEach(taskInfo =>
                {
                    ITaskExecutor taskExecutor = (ITaskExecutor)work.CreateComponent(taskInfo.TaskType);
                    try
                    {
                        logger.Info(string.Format("开始执行 [{0}]", taskInfo.TaskAttribute.Name));
                        taskExecutor.Execute();
                        logger.Info(string.Format("[{0}] 执行完成", taskInfo.TaskAttribute.Name));
                    }
                    catch (System.Exception ex)
                    {
                        logger.Error(string.Format("[{0}] 执行失败 : {1}", taskInfo.TaskAttribute.Name, ex.Message));
                    }
                });
            }
        }
    }
}
