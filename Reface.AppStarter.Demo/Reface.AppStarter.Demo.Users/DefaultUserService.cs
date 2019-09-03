using Reface.AppStarter.Attributes;

namespace Reface.AppStarter.Demo.Users
{
    [Component]
    public class DefaultUserService : IUserService
    {
        public bool CheckUserNameAndPassword(User user)
        {
            return user.Name == "admin" && user.Password == "888888";
        }
    }
}
