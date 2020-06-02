using System;
using StandartMessenger_Factory_Method.Abstractions;

namespace StandartMessenger_Factory_Method.Concreete
{
    public class TwitterMessagner : MessangerBase
    {
        public TwitterMessagner(string userName, string password) : base(userName, password)
        {
        }

        public override bool Authorize()
        {
            //TODO: Api Twitter for Authorize
            Console.WriteLine($"Authorize user  -->username: {UserName},  password: {Password}");
            return true;
        }

        public override IMessage CreateMessage(string text, string source, string target)
        {
           var message = new TwitterMessage(text, source, target);
           return message;
        }
    }
}