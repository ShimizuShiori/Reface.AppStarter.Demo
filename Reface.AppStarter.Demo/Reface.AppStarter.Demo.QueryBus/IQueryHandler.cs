using Newtonsoft.Json.Linq;

namespace Reface.AppStarter.Demo.QueryBus
{
    public interface IQueryHandler
    {
        string QueryType { get; }

        object Handle(JObject args);
    }
}
