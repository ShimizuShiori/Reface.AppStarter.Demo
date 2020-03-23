using Reface.AppStarter.AppModules;
using Reface.AppStarter.Demo.Users;

namespace Reface.AppStarter.Demo
{
    /// <summary>
    /// 示例模块
    /// </summary>
    [ComponentScanAppModule]
    [UserAppModule]
    public class DemoAppModule : AppModule
    {
    }
}
