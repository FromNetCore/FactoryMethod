using System;

namespace StandartMessenger
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var messanger = new TestMessanger("my_username", "my_password");
            messanger.SendMessage("Hello World", "C# deveoper", "Bill");
            
            
            Console.ReadKey();
        }
    }
}