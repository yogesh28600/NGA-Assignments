using AspEFCore.AbstractFactory.AbstractProducts;

namespace AspEFCore.AbstractFactory.ConcreteClasses.SystemTypes
{
    public class Desktop : ISystemType
    {
        public Enums.SystemType GetSystemType()
        {
            return Enums.SystemType.Desktop;
        }
    }
}
