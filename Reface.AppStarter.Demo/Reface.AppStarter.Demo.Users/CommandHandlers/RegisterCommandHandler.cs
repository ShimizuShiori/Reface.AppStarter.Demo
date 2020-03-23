using Reface.AppStarter.Attributes;
using Reface.AppStarter.Demo.Users.Commands;
using Reface.CommandBus;

namespace Reface.AppStarter.Demo.Users.CommandHandlers
{
    [CommandHandler]
    public class RegisterCommandHandler : ICommandHandler<RegisterUserCommand>
    {
        private readonly IUserService userService;

        public RegisterCommandHandler(IUserService userService)
        {
            this.userService = userService;
        }

        public object Handler(RegisterUserCommand command)
        {
            return this.userService.Register(command.Name, command.Password);
        }
    }
}
