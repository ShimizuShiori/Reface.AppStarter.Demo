using Reface.AppStarter.AppModules;
namespace Reface.AppStarter.Demo
{
    /// <summary>
    /// 示例模块
    /// </summary>
    [ComponentScanAppModule] // 自动注册组件模块
    [TaskAppModule] // 依赖任务模块，系统启动后会自动执行所有任务
    public class DemoAppModule : AppModule
    {
    }
}
