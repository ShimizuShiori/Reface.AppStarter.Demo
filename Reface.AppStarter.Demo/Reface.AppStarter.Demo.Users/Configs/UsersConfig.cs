using Reface.AppStarter.Attributes;
using System;

namespace Reface.AppStarter.Demo.Users.Configs
{
    [Config("Users")]
    public class UsersConfig
    {
        public string Admin { get; set; } = "admin";
        public string Password { get; set; } = "12345678";
        public string AdminId { get; set; } = Guid.Empty.ToString();

        public override string ToString()
        {
            return string.Format("{0}-{1}-{2}", AdminId, Admin, Password);
        }
    }
}
