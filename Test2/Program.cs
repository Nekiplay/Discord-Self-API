using Discord_Self_API.Implementations;

namespace Tests // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        private static string token = "";
        static void Main(string[] args)
        {
            MessageManager messageManager = new MessageManager(token);

        }
    }
}