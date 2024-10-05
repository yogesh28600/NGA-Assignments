using AspEFCore.AbstractFactory.AbstractInterface;
using AspEFCore.AbstractFactory.AbstractProducts;
using AspEFCore.AbstractFactory.ConcreteClasses.SystemTypes;

namespace AspEFCore.AbstractFactory.ConcreteClasses.Computers
{
    public class PermanentManager :Manager, IComputerFactory
    {

        public ISystemType SystemType()
        {
            return new Laptop();
        }
    }
}
