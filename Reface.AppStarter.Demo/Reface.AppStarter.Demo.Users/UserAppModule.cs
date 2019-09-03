using System.Collections.Generic;
using Reface.AppStarter.AppModules;

namespace Reface.AppStarter.Demo.Users
{
    /// <summary>
    /// 用户模块
    /// </summary>
    public class UserAppModule : AppModule
    {
        public override IEnumerable<IAppModule> DependentModules => new IAppModule[]
        {
            new ComponentScanAppModule(this) // 依赖组件扫描功能
        };
    }
}
