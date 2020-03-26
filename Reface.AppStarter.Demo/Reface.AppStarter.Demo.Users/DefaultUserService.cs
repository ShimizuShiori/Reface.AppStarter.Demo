using Reface.AppStarter.Attributes;
using Reface.AppStarter.Demo.Logger;
using Reface.AppStarter.Demo.Logger.Attributes;
using Reface.AppStarter.Demo.Users.Configs;
using System;

namespace Reface.AppStarter.Demo.Users
{
    [Component]
    public class DefaultUserService : IUserService
    {
        private readonly UsersConfig usersConfig;
        private readonly ILogger logger;

        public DefaultUserService(UsersConfig usersConfig, ILogger logger)
        {
            this.usersConfig = usersConfig;
            this.logger = logger;

        }

        [Logger]
        public bool CheckUserNameAndPassword(User user)
        {
            if (user.Name == this.usersConfig.Admin && user.Password == this.usersConfig.Password)
                return true;
            return false;
        }

        [Logger]
        public string Register(string name, string password)
        {
            if (name == this.usersConfig.Admin)
                throw new ApplicationException(Constant.ERROR_MSG_USER_NAME_EXISTS);
            return Guid.NewGuid().ToString();
        }
    }
}
