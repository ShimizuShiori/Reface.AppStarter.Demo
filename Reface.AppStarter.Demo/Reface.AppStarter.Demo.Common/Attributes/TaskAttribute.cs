using Reface.AppStarter.Attributes;
using System;

namespace Reface.AppStarter.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class TaskAttribute : ScannableAttribute
    {
        public string Name { get; private set; }
        public int Order { get; private set; }

        public TaskAttribute(string name, int order = int.MaxValue)
        {
            Name = name;
            Order = order;
        }
    }
}
