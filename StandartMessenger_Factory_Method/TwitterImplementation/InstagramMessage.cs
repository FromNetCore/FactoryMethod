using System;
using System.IO;
using StandartMessenger_Factory_Method.Abstractions;

namespace StandartMessenger_Factory_Method.Concreete
{
    public class InstagramMessage : MessageBase
    {
        public InstagramMessage(string text, string source, string target) : base(text, source, target)
        {
            //TODO: text validations
            if (File.Exists(text))
            {
                var imageFile = File.ReadAllBytes(text);
                var base64String = Convert.ToBase64String(imageFile);
                Text = base64String;
            }
        }

        public override void Send()
        {
            //TODO: Api for send message  from instagram
            Console.WriteLine($"Instagram photo from {Source} To {Target} {Text}");
        }
    }
}