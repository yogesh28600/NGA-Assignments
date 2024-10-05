using AspEFCore.AbstractFactory.AbstractProducts;

namespace AspEFCore.AbstractFactory.ConcreteClasses.SystemTypes
{
    public class Laptop : ISystemType
    {
        public Enums.SystemType GetSystemType()
        {
            return Enums.SystemType.Laptop;
        }
    }
}
