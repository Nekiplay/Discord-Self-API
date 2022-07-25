using Discord_Self_API.Data.Messages;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Discord_Self_API.Implementations
{
    public class MessageManager
    {
        public MessageManager(string token)
        {
            this._token = token;
        }

        
        private string _token;

        public string Token { get { return _token; } }

        public List<Message> GetMessages(ulong gild)
        {
            var request = Request.SendGet($"/channels/{gild}/messages", _token);
            var messages = JsonConvert.DeserializeObject<List<Message>>(request);
            return messages;
        }

        public void SendMessage(ulong gild, string message)
        {
            JObject o = JObject.Parse(@"{
                'content': ''
            }");
            o["content"] = message;
            Console.WriteLine(o.ToString());
            Request.Send($"/channels/{gild}/messages", "POST", _token, o.ToString());
        }

        public void EditMessage(ulong gild, ulong message_id, string message)
        {
            JObject o = JObject.Parse(@"{
                'content': ''
            }");
            o["content"] = message;
            Console.WriteLine(o.ToString());
            Request.Send($"/channels/{gild}/messages/{message_id}", "PATCH", _token, o.ToString());
        }
    }
}
