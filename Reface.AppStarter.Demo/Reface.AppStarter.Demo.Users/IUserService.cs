namespace Reface.AppStarter.Demo.Users
{
    public interface IUserService
    {
        bool CheckUserNameAndPassword(User user);

        string Register(string name, string password);
    }
}
