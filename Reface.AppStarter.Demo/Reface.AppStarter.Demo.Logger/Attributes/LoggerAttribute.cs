using Reface.AppStarter.Attributes;
using Reface.AppStarter.Proxy;
using System;

namespace Reface.AppStarter.Demo.Logger.Attributes
{
    [AttributeUsage(AttributeTargets.Method)]
    public class LoggerAttribute : ProxyAttribute
    {
        public ILogger Logger { get; set; }

        public override void OnExecuted(ExecutedInfo executedInfo)
        {
            Logger.Info($"Executed : {executedInfo.ReturnedValue}");
        }

        public override void OnExecuteError(ExecuteErrorInfo executeErrorInfo)
        {
            Logger.Info($"Error : {executeErrorInfo.Error.Message}");
        }

        public override void OnExecuting(ExecutingInfo executingInfo)
        {
            Logger.Info($"Executing : {executingInfo.ToString()}");
        }
    }
}
