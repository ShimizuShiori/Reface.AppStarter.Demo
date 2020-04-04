using Reface.AppStarter.AppModules;
using Reface.AppStarter.Demo.FileStorage;
using Reface.AppStarter.Demo.Logger;

namespace Reface.AppStarter.Demo.Users
{
    /// <summary>
    /// 用户模块
    /// </summary>
    [ComponentScanAppModule]
    [AutoConfigAppModule]
    [LoggerAppModule]
    [FileStorageAppModule]
    public class UserAppModule : AppModule
    {
    }
}
