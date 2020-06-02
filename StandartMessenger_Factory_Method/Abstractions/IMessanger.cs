namespace StandartMessenger_Factory_Method.Abstractions
{
    public interface IMessanger
    {
        string UserName { get; }
        string Password { get; }
        bool IsConnected { get; }
        bool Authorize();
        IMessage CreateMessage(string text, string source, string target);
        
    }
}