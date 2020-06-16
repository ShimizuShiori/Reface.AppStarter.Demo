using Reface.AppStarter.Attributes;
using Reface.AppStarter.Demo.Logger.Attributes;
using Reface.AppStarter.Proxy;
using Reface.AppStarter.Proxy.Attachments;

namespace Reface.AppStarter.Demo.Logger.Proxies
{
    [AttachedProxy]
    [TypeHasAttribute(typeof(LoggerAttribute))]
    public class LoggerProxy : IProxy
    {
        private readonly ILogger logger;

        public LoggerProxy(ILogger logger)
        {
            this.logger = logger;
        }

        public void OnExecuted(ExecutedInfo executedInfo)
        {
            logger.Info($"Executed : {executedInfo.ReturnedValue}");
        }

        public void OnExecuteError(ExecuteErrorInfo executeErrorInfo)
        {
            logger.Info($"Error : {executeErrorInfo.Error.Message}");
        }

        public void OnExecuting(ExecutingInfo executingInfo)
        {
            logger.Info($"Executing : {executingInfo.ToString()}");
        }
    }
}
