using Discord_Self_API.Data.Messages;
using Discord_Self_API.Data.User;
using Discord_Self_API.Implementations;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BrokenCore_content_makers
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow instance = null;
        public MainWindow()
        {
            InitializeComponent();
            instance = this;
        }
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            Load();
        }

        private void Load()
        {

            List<ContentMaker> users = new List<ContentMaker>();
            Dispatcher.Invoke((Action)(() =>
            {
                GG.Items.Clear();
            }));

            string token = "MzEzNjYzODcyMjI3NzM3NjAx.GM3Cc0.oKyFpZiYpuHpz4TQ58P5pN_UwTOcXNoaYzgXIU";

            List<Message> messages = MessageManager.GetMessages(996367429473161356, token);
            Message last = messages.Last();
            if (last != null)
            {
                string[] strings = last.content.Split("\n", StringSplitOptions.None);
                foreach (string s in strings)
                {
                    string s2 = s.Replace("@", "&" + " ").Replace("> ", " ").Replace("|", "&").Replace("/", "/");
                    var regex = Regex.Match(s2, "& ([0-9]*) & (.*) & ([0-9]*)/([0-9]*) & ([0-9]*)");
                    if (regex.Success)
                    {
                        ulong id = Convert.ToUInt64(regex.Groups[1].Value);
                        User user = UserManager.GetUser(id, token);
                        string category = regex.Groups[2].Value;
                        long warns = Convert.ToInt64(regex.Groups[3].Value);
                        long max_warns = Convert.ToInt64(regex.Groups[4].Value);
                        long points = Convert.ToInt64(regex.Groups[5].Value);
                        MessageManager.GetMessages(996367429473161356, token);

                        WebClient client = new WebClient();
                        Stream stream = client.OpenRead("https://cdn.discordapp.com/avatars/" + id + "/" + user.avatar + ".png");
                        Bitmap bitmap; bitmap = new Bitmap(stream);
                        ImageBrush b = new ImageBrush();
                        using (MemoryStream memory = new MemoryStream())
                        {
                            bitmap.Save(memory, ImageFormat.Png);
                            memory.Position = 0;
                            BitmapImage bitmapImage = new BitmapImage();
                            bitmapImage.BeginInit();
                            bitmapImage.StreamSource = memory;
                            bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                            bitmapImage.EndInit();
                            users.Add(new ContentMaker(bitmapImage, user.username, category, warns, max_warns, points, user));
                        }
                    }
                }
            }
            users = users.OrderByDescending(x => x.Points).ToList();

            foreach (var contantMaker in users)
            {
                MainWindow.instance.Dispatcher.Invoke((Action)(() =>
                {
                    GG.Items.Add(contantMaker);
                }));

            }

        }
    }
}
