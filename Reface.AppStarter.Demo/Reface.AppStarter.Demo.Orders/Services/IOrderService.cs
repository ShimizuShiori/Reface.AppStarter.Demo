using Reface.AppStarter.Demo.Orders.Models;

namespace Reface.AppStarter.Demo.Orders.Services
{
    public interface IOrderService
    {
        void Create(Order order);
    }
}
