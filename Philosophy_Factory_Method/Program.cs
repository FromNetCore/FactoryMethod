using System;
using Philosophy_Factory_Method.Abstractions;
using Philosophy_Factory_Method.Concrete;

namespace Philosophy_Factory_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator creator = new ConcreteCreator();

            Product product = creator.Factory_Method();

            ConcreteProduct concreteProduct = product as ConcreteProduct;
            concreteProduct.DoWork();
        }
    }
}