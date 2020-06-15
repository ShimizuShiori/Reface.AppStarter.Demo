using Reface.AppStarter.Attributes;
using System;

namespace Reface.AppStarter.Demo.Tasks
{
    public class TaskInfo
    {
        public TaskAttribute TaskAttribute { get; set; }
        public Type TaskType { get; set; }
    }
}
