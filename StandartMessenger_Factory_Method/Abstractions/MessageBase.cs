namespace StandartMessenger_Factory_Method.Abstractions
{
    public abstract class MessageBase : IMessage
    {
        public string Text { get; protected set; }
        public string Source { get; }
        public string Target { get; }


        public MessageBase(string text, string source, string target)
        {
            Text = text;
            Source = source;
            Target = target;
        }

        public abstract void Send();

    }
}