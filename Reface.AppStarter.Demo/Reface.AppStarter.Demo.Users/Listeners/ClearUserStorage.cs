using Reface.AppStarter.Attributes;
using Reface.AppStarter.Demo.FileStorage;
using Reface.AppStarter.Events;
using Reface.EventBus;

namespace Reface.AppStarter.Demo.Users.Listeners
{
    [Listener]
    public class ClearUserStorage : IEventListener<AppStartedEvent>
    {
        private readonly IFileStorage<User> fileStorage;

        public ClearUserStorage(IFileStorage<User> fileStorage)
        {
            this.fileStorage = fileStorage;
        }

        public void Handle(AppStartedEvent @event)
        {
            this.fileStorage.Clear();
        }
    }
}
