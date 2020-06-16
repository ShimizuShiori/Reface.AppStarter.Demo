using System;

namespace Reface.AppStarter.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // 启动示例模块
            // 会以 app.json 为配置文件进行启动
            new AppSetup().Start(new DemoAppModule());

            Console.ReadLine();
        }
    }
}
