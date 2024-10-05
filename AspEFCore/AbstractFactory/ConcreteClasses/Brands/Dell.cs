using AspEFCore.AbstractFactory.AbstractProducts;

namespace AspEFCore.AbstractFactory.ConcreteClasses.Brands
{
    public class Dell : IBrand
    {
        public Enums.Brand GetBrand()
        {
            return Enums.Brand.Dell;
        }
    }
}
