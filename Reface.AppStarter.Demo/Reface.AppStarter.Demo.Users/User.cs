using Reface.AppStarter.Demo.FileStorage;
using System;

namespace Reface.AppStarter.Demo.Users
{
    [Serializable]
    public class User : IStorageData
    {
        public string Name { get; set; }
        public string Password { get; set; }

        public IStorageData Copy()
        {
            return (User)this.MemberwiseClone();
        }
    }
}
