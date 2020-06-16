using Reface.AppStarter.Attributes;
using Reface.AppStarter.Demo.Logger;
using Reface.AppStarter.Demo.Orders.Models;
using Reface.AppStarter.Demo.Orders.Providers;

namespace Reface.AppStarter.Demo.Orders.Services
{
    [Component]
    public class DefaultOrderService : IOrderService
    {
        private readonly IUserProvider userProvider;
        private readonly ILogger logger;

        public DefaultOrderService(IUserProvider userProvider, ILogger logger)
        {
            this.userProvider = userProvider;
            this.logger = logger;
        }

        public void Create(Order order)
        {
            User user = this.userProvider.GetById(order.CreateUserId);
            order.CreateUserName = user.Name;
            logger.Message(string.Format("order created : {0}", order));
        }
    }
}
