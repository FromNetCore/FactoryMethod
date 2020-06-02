using System;
using Philosophy_Factory_Method.Abstractions;

namespace Philosophy_Factory_Method.Concrete
{
    public class ConcreteProduct : Product
    {
        public override void DoWork()
        {
            Console.WriteLine("Some work");
        }
    }
}