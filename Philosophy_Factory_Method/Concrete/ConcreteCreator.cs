using Philosophy_Factory_Method.Abstractions;

namespace Philosophy_Factory_Method.Concrete
{
    public class ConcreteCreator : Creator
    {
        public override Product Factory_Method()
        {
            return new ConcreteProduct();
        }
    }
}