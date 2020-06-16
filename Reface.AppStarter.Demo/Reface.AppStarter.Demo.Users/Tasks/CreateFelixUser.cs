using Reface.AppStarter.Attributes;
using Reface.AppStarter.Demo.Tasks;
using System.Threading.Tasks;

namespace Reface.AppStarter.Demo.Users.Tasks
{
    [Task("创建名为 Felix 的用户")]
    public class CreateFelixUser : ITaskExecutor
    {
        private readonly IUserService userService;

        public CreateFelixUser(IUserService userService)
        {
            this.userService = userService;
        }

        public void Execute()
        {
            this.userService.Create(new User() 
            { 
                Name="Felix"
            });
        }
    }
}
