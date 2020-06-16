using Reface.AppStarter.Attributes;
using Reface.AppStarter.Demo.Tasks;
using System.Threading.Tasks;

namespace Reface.AppStarter.Demo.Users.Tasks
{
    [Task("创建名为 root 的用户")]
    public class CreateRootUser : ITaskExecutor
    {
        private readonly IUserService userService;

        public CreateRootUser(IUserService userService)
        {
            this.userService = userService;
        }

        public void Execute()
        {
            this.userService.Create(new User()
            {
                Name = "root"
            });
        }
    }
}
