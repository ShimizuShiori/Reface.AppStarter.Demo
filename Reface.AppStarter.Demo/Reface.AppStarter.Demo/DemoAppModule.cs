using Reface.AppStarter.AppModules;
using Reface.AppStarter.Attributes;
using Reface.AppStarter.Demo.Logger;
using Reface.AppStarter.Demo.Orders;
using Reface.AppStarter.Demo.QueryBus;
using Reface.AppStarter.Demo.Users;

namespace Reface.AppStarter.Demo
{
    /// <summary>
    /// 示例模块
    /// </summary>
    [ComponentScanAppModule] // 自动注册组件模块
    [LoggerAppModule] // 日志模块，启动与日志相关的组件
    [QueryBusAppModule] // 查询总线
    [UserAppModule] // 依赖用户模块
    [OrderAppModule] // 订单模块
    public class DemoAppModule : AppModule
    {
        /// <summary>
        /// 该特征表示实现返回的类型替换已有的 <see cref="ILogger"/> 组件。
        /// 方法签名中的返回类型是替换的目标，
        /// 方法中实现的返回类型是新的组件。
        /// </summary>
        /// <returns></returns>
        [ReplaceCreator]
        public ILogger GetLogger()
        {
            return new ConsoleLogger();
        }
    }
}
