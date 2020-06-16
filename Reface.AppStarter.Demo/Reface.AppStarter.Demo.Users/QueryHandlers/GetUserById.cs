using Newtonsoft.Json.Linq;
using Reface.AppStarter.Attributes;
using Reface.AppStarter.Demo.QueryBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reface.AppStarter.Demo.Users.QueryHandlers
{
    [Component]
    public class GetUserById : IQueryHandler
    {
        private readonly IUserService userService;

        public GetUserById(IUserService userService)
        {
            this.userService = userService;
        }

        public string QueryType => "GetUserById";

        public object Handle(JObject args)
        {
            string id = args["Id"].Value<string>();
            return this.userService.GetById(id);

        }
    }
}
