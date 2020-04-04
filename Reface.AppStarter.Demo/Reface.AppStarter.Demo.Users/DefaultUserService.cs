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
        private readonly ILogger logger;
        private readonly IFileStorage<User> userStorage;

        public DefaultUserService(UsersConfig usersConfig, ILogger logger, IFileStorage<User> userStorage)
        {
            this.usersConfig = usersConfig;
            this.logger = logger;
            this.userStorage = userStorage;
        }

        public void Create(User user)
        {
            if (user.Name == usersConfig.Admin)
            {
                this.logger.Error("用户名不能与管理员相同");
            }
            this.userStorage.Insert(new User()
            {
                Name = user.Name,
                Password = user.Password
            });
        }
    }
}
