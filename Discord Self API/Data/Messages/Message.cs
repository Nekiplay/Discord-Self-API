namespace Discord_Self_API.Data.Messages
{
    public class Attachment
    {
        public string id { get; set; }
        public string filename { get; set; }
        public int size { get; set; }
        public string url { get; set; }
        public string proxy_url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public string content_type { get; set; }
    }

    public class Author
    {
        public string id { get; set; }
        public string username { get; set; }
        public string avatar { get; set; }
        public object avatar_decoration { get; set; }
        public string discriminator { get; set; }
        public int public_flags { get; set; }
    }

    public class Mention
    {
        public string id { get; set; }
        public string username { get; set; }
        public string avatar { get; set; }
        public object avatar_decoration { get; set; }
        public string discriminator { get; set; }
        public int public_flags { get; set; }
    }

    public class MessageReference
    {
        public string channel_id { get; set; }
        public string guild_id { get; set; }
        public string message_id { get; set; }
    }

    public class ReferencedMessage
    {
        public string id { get; set; }
        public int type { get; set; }
        public string content { get; set; }
        public string channel_id { get; set; }
        public Author author { get; set; }
        public List<Attachment> attachments { get; set; }
        public List<object> embeds { get; set; }
        public List<Mention> mentions { get; set; }
        public List<object> mention_roles { get; set; }
        public bool pinned { get; set; }
        public bool mention_everyone { get; set; }
        public bool tts { get; set; }
        public DateTime timestamp { get; set; }
        public DateTime? edited_timestamp { get; set; }
        public int flags { get; set; }
        public List<object> components { get; set; }
        public MessageReference message_reference { get; set; }
    }

    public class Message
    {
        public string id { get; set; }
        public int type { get; set; }
        public string content { get; set; }
        public string channel_id { get; set; }
        public Author author { get; set; }
        public List<Attachment> attachments { get; set; }
        public List<object> embeds { get; set; }
        public List<Mention> mentions { get; set; }
        public List<object> mention_roles { get; set; }
        public bool pinned { get; set; }
        public bool mention_everyone { get; set; }
        public bool tts { get; set; }
        public DateTime timestamp { get; set; }
        public DateTime? edited_timestamp { get; set; }
        public int flags { get; set; }
        public List<object> components { get; set; }
        public MessageReference message_reference { get; set; }
        public ReferencedMessage referenced_message { get; set; }
    }
}
