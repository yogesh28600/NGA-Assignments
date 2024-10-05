using AspEFCore.AbstractFactory.AbstractProducts;
using AspEFCore.AbstractFactory.ConcreteClasses.Brands;
using AspEFCore.AbstractFactory.ConcreteClasses.Processors;

namespace AspEFCore.AbstractFactory.ConcreteClasses.Computers
{
    public class Manager
    {
        public IBrand Brand()
        {
            return new Apple();
        }

        public IProcessor Processor()
        {
            return new I5();
        }
    }
}
