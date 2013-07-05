using Dig.Data.Models;

namespace Dig.Data.Maps
{
    public class UserMap : BaseModelMap<User>
    {
        public UserMap()
        {
            Property(x => x.UserName);
            Property(x => x.Password);
            Property(x => x.Nickname);
        }
    }
}
