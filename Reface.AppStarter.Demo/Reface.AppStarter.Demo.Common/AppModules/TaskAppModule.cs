using Reface.AppStarter.AppContainerBuilders;

namespace Reface.AppStarter.AppModules
{
    public class TaskAppModule : AppModule
    {
        public override void OnUsing(AppModuleUsingArguments args)
        {
            var builder = args.AppSetup.GetAppContainerBuilder<TaskContainerBuilder>();
            args.ScannedAttributeAndTypeInfos.ForEach(info => builder.AddTask(info));
        }
    }
}
