using System.Collections.Generic;
using Reface.AppStarter.AppModules;
using Reface.AppStarter.Demo.Users;

namespace Reface.AppStarter.Demo
{
    /// <summary>
    /// 示例模块
    /// </summary>
    public class DemoAppModule : AppModule
    {
        public override IEnumerable<IAppModule> DependentModules
            =>
            new IAppModule[]
            {
                new ComponentScanAppModule(this), // 组件扫描模块
                new UserAppModule() // 用户模块
            };
    }
}
