namespace Discord_Self_API.Data.User
{
    public class User
    {
        public string id { get; set; }
        public string username { get; set; }
        public string avatar { get; set; }
        public object avatar_decoration { get; set; }
        public string discriminator { get; set; }
        public int public_flags { get; set; }
        public object banner { get; set; }
        public object banner_color { get; set; }
        public object accent_color { get; set; }
    }
}
