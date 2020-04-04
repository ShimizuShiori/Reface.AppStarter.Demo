using Reface.AppStarter.Attributes;
using Reface.AppStarter.Demo.Users;

namespace Reface.AppStarter.Demo.Tasks
{
    [Component]
    public class CreateUserTask : ITask
    {
        public string TaskName => "创建用户";

        private readonly IUserService userService;

        public CreateUserTask(IUserService userService)
        {
            this.userService = userService;
        }

        public void Do()
        {
            string userName = "userName";
            string password = "pwd";
            this.userService.Create(new User()
            {
                Name = userName,
                Password = password
            });
        }
    }
}
