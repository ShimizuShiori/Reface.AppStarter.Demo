using Reface.AppStarter.Attributes;
using Reface.AppStarter.Demo.Logger.Attributes;
using Reface.AppStarter.Demo.Users.Configs;
using System;

namespace Reface.AppStarter.Demo.Users
{
    /// <summary>
    /// 假定的用户服务的实现类
    /// </summary>
    [Component] // 添加此特征会自动注入到 IOC 容器中
    [Logger] // 添加此特征会创建与日志相关的 AOP
    public class DefaultUserService : IUserService
    {
        /// <summary>
        /// 使用用户相关的配置
        /// </summary>
        private readonly UsersConfig usersConfig;

        /// <summary>
        /// 通过构造函数注入配置信息。
        /// 当 app.json 有配置时，会进行反序列化。
        /// 若 app.json 没有相关配置或没有 app.json 文件时，会使用默认值
        /// </summary>
        /// <param name="usersConfig"></param>
        public DefaultUserService(UsersConfig usersConfig)
        {
            this.usersConfig = usersConfig;
        }

        public void Create(User user)
        {
            if (user.Name == this.usersConfig.Admin)
                throw new ApplicationException("指定的用户名是管理员，无法创建");
        }

        public User GetById(string id)
        {
            if (id == this.usersConfig.AdminId)
                return new User() { Id = id, Name = this.usersConfig.Admin, Password = this.usersConfig.Password };
            return new User()
            {
                Id = id,
                Name = $"User_{id}",
                Password = ""
            };
        }
    }
}
