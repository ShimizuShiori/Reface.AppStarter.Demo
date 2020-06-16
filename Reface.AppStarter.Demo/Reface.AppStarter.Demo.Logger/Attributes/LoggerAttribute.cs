using System;

namespace Reface.AppStarter.Demo.Logger.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class LoggerAttribute : Attribute
    {
    }
}
