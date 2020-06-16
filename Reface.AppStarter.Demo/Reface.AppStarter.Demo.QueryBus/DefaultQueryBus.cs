using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Reface.AppStarter.Attributes;

namespace Reface.AppStarter.Demo.QueryBus
{
    [Component]
    public class DefaultQueryBus : IQueryBus
    {
        private readonly IEnumerable<IQueryHandler> handlers;

        public DefaultQueryBus(IEnumerable<IQueryHandler> handlers)
        {
            this.handlers = handlers;
        }

        public TResult Query<TResult>(string queryType, object args)
        {
            string json = JsonConvert.SerializeObject(args);
            JObject jObject = JObject.Parse(json);
            foreach (var handler in handlers)
            {
                if (handler.QueryType != queryType) continue;
                object result = handler.Handle(jObject);
                string resultJson = JsonConvert.SerializeObject(result);
                return (TResult)JsonConvert.DeserializeObject(resultJson, typeof(TResult));
            }
            throw new NotImplementedException($"未实现此查询 : {queryType}");
        }
    }
}
