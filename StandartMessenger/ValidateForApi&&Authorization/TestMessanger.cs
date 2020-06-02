using System;

namespace StandartMessenger
{
    public class TestMessanger
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsConnected { get; set; }

        public TestMessanger(string username, string password)
        {
            UserName = username;
            Password = password;
            IsConnected = ConnectToTwitter();
        }

        public void SendMessage(string text, string source, string target)
        {
            var message = new TestMessage(text, source, target);
            SendMessageToTwitter(message);
        }

        private void SendMessageToTwitter(TestMessage message)
        {
            //TODO: Api twitter for send message
            Console.WriteLine($"Twitter: {message.Text}");
        }

        private bool ConnectToTwitter()
        {
            //TODO: Api for twitter
            Console.WriteLine($"Auth in twitter user, username: {UserName}, password: {Password}");
            return true;
        }
    }
}