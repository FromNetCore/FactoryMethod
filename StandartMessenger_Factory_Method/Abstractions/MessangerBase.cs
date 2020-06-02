namespace StandartMessenger_Factory_Method.Abstractions
{
    public abstract class MessangerBase : IMessanger
    {
        public string UserName { get; }
        public string Password { get; }
        public bool IsConnected { get; }

        public MessangerBase(string userName, string password)
        {
            UserName = userName;
            Password = password;
            IsConnected = Authorize();
        }
        
        public abstract  bool Authorize();
        public abstract IMessage CreateMessage(string text, string source, string target);

    }
}