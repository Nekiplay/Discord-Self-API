using Discord_Self_API.Data.User;
using Newtonsoft.Json;

namespace Discord_Self_API.Implementations
{
    public class UserManager
    {
        public User GetUser(ulong userId, string token)
        {
            var request = Request.SendGet($"/users/{userId}", token);
            var user = JsonConvert.DeserializeObject<User>(request);
            return user;
        }
    }
}
