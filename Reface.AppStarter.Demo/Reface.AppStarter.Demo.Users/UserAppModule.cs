using Reface.AppStarter.AppModules;

namespace Reface.AppStarter.Demo.Users
{
    /// <summary>
    /// 用户模块
    /// </summary>
    [ComponentScanAppModule] // 对用户模块内的组件进行扫描，自动注入到IOC容器中
    [AutoConfigAppModule] // 自动配置模块，将 app.json 相应节点的内容映射到标有 [Config] 的类型上
    [TaskAppModule] // 任务模块，扫描当前模块中的任务实例，并在应用程序启动后执行它们
    public class UserAppModule : AppModule
    {
    }
}
