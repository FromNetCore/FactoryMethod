using System.IO;

namespace StandartMessenger_Factory_Method.Abstractions
{
    public interface IMessage
    {
        public string Text { get; }
        public  string Source { get; }
        public  string Target { get; }
        public void Send(); 
    }
}