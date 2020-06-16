using Reface.AppStarter.Attributes;
using Reface.AppStarter.Demo.Orders.Models;
using Reface.AppStarter.Demo.QueryBus;

namespace Reface.AppStarter.Demo.Orders.Providers
{
    [Component]
    public class DefaultUserProvider : IUserProvider
    {
        private readonly IQueryBus queryBus;

        public DefaultUserProvider(IQueryBus queryBus)
        {
            this.queryBus = queryBus;
        }
        public User GetById(string id)
        {
            return this.queryBus.Query<User>("GetUserById", new { Id = id });
        }
    }
}
