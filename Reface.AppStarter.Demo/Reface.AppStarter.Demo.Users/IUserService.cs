namespace Reface.AppStarter.Demo.Users
{
    /// <summary>
    /// 假设的一个用户服务 
    /// </summary>
    public interface IUserService
    {
        User GetById(string id);
        void Create(User user);
    }
}
