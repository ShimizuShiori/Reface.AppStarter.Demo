using Reface.CommandBus;

namespace Reface.AppStarter.Demo.Users.Commands
{
    public class RegisterUserCommand : ICommand
    {
        public string Name { get; set; }
        public string Password { get; set; }
    }
}
