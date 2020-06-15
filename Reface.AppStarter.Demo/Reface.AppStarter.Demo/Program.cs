﻿using Reface.AppStarter.AppContainers;
using Reface.AppStarter.Demo.Logger;
using System;
using System.Collections.Generic;

namespace Reface.AppStarter.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // 应用程序安装类
            AppSetup setup = new AppSetup();

            // 启动示例模块
            var app = setup.Start(new DemoAppModule());

            Console.ReadLine();
        }
    }
}
