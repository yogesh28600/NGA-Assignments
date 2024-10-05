using AspEFCore.AbstractFactory.AbstractProducts;

namespace AspEFCore.AbstractFactory.ConcreteClasses.Brands
{
    public class Apple : IBrand
    {
        public Enums.Brand GetBrand()
        {
            return Enums.Brand.Apple;
        }
    }
}
