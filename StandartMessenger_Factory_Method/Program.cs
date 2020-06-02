using System;
using StandartMessenger_Factory_Method.Concreete;

namespace StandartMessenger_Factory_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var twitMessanger = new TwitterMessagner("username", "password");
            var twit = twitMessanger.CreateMessage("Hello World", "Customer", "Custumer2");
            twit.Send();
            Console.WriteLine(new string('-', 50));

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/aaa.jpg";
            var instagramMessanger = new InstagramMessanger("username", "password");
            var insta = instagramMessanger.CreateMessage(path, "InstaCustomer", "InstaCustomer2");
            insta.Send();
            
            
            
            Console.ReadKey();
        }
    }
}