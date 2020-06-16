using System;

namespace Reface.AppStarter.Demo.Orders.Models
{
    public class Order
    {
        public string CreateUserId { get; set; }
        public string CreateUserName { get; set; }

        public override string ToString()
        {
            return $"Order by [{this.CreateUserName}]";
        }
    }
}
