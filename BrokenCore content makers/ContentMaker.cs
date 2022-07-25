using Discord_Self_API.Data.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace BrokenCore_content_makers
{
    public class ContentMaker
    {
        public BitmapImage Image { get; set; }
        public string Username { get; set; }
        public string Category { get; set; }
        public long Warns { get; set; }
        public long Max_warns { get; set; }
        public long Points { get; set; }
        public User User { get; set; }
        public ContentMaker(BitmapImage image, string username, string category, long warns, long max_warns, long points, User user)
        {
            this.Points = points;
            this.Max_warns = max_warns;
            this.Warns = warns;
            this.Category = category;
            this.Username = username;
            this.Image = image;
        }
    }
}
