using System;
using StandartMessenger_Factory_Method.Abstractions;

namespace StandartMessenger_Factory_Method.Concreete
{
    public class InstagramMessanger : MessangerBase
    {
        public InstagramMessanger(string userName, string password) : base(userName, password)
        {
        }

        public override bool Authorize()
        {
            //TODO: Api for authorize in instagram
            Console.WriteLine($"Authorize in instagram user: {UserName} passwird: {Password}");
            return true;
        }

        public override IMessage CreateMessage(string text, string source, string target)
        {
            //TODO: all validations 
            var message = new InstagramMessage(text, source,target);
            return message;
        }
    }
}