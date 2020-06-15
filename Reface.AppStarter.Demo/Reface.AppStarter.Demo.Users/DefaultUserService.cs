using Reface.AppStarter.Attributes;
using Reface.AppStarter.Demo.FileStorage;
using Reface.AppStarter.Demo.Logger;
using Reface.AppStarter.Demo.Users.Configs;

namespace Reface.AppStarter.Demo.Users
{
    [Component]
    public class DefaultUserService : IUserService
    {
        private readonly UsersConfig usersConfig;

        public DefaultUserService(UsersConfig usersConfig)
        {
            this.usersConfig = usersConfig;
        }

        public void Create(User user)
        {
        }
    }
}
