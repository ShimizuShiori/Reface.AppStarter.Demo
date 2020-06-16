namespace Reface.AppStarter.Demo.QueryBus
{
    public interface IQueryBus
    {
        TResult Query<TResult>(string queryType, object args);
    }
}
