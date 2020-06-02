using System;
using StandartMessenger_Factory_Method.Abstractions;

namespace StandartMessenger_Factory_Method.Concreete
{
    public class TwitterMessage : MessageBase
    {
        public TwitterMessage(string text, string source, string target) : base(text, source, target)
        {
            //TODO: validations for text
            Text = text;
        }

        public override void Send()
        {
           //TODO: Api for Twitter
           Console.WriteLine($"Twit from {Source} for {Target} {Text}");
            
        }
    }
}