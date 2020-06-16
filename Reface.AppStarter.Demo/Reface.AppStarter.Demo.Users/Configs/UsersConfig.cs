using Reface.AppStarter.Attributes;
using System;

namespace Reface.AppStarter.Demo.Users.Configs
{
    /// <summary>
    /// 用户模块的配置
    /// </summary>
    [Config("Users")] // 该特征指定该类型是一个配置项，会以单例模式注入到 IOC 容器中。 "Users" 表示 app.json 中的哪个节点的内容向此类型反序列化
    public class UsersConfig
    {
        public string Admin { get; set; } = "admin";
        public string Password { get; set; } = "12345678";
        public string AdminId { get; set; } = Guid.Empty.ToString();

        public override string ToString()
        {
            return string.Format("{0}-{1}-{2}", AdminId, Admin, Password);
        }
    }
}
