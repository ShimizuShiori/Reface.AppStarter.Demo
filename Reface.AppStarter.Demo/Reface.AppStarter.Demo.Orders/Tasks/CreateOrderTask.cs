using Reface.AppStarter.Attributes;
using Reface.AppStarter.Demo.Orders.Models;
using Reface.AppStarter.Demo.Orders.Services;
using Reface.AppStarter.Demo.Tasks;
using System.Threading.Tasks;

namespace Reface.AppStarter.Demo.Orders.Tasks
{
    [Task("创建订单")]
    public class CreateOrderTask : ITaskExecutor
    {
        private readonly IOrderService orderService;

        public CreateOrderTask(IOrderService orderService)
        {
            this.orderService = orderService;
        }

        public void Execute()
        {
            this.orderService.Create(new Order()
            {
                CreateUserId = "123"
            });
        }
    }
}
