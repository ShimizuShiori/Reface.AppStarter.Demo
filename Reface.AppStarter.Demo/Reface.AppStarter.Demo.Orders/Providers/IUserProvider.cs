using Reface.AppStarter.Demo.Orders.Models;

namespace Reface.AppStarter.Demo.Orders.Providers
{
    public interface IUserProvider
    {
        User GetById(string id);
    }
}
