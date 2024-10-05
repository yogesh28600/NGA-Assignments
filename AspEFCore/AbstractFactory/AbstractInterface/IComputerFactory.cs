using AspEFCore.AbstractFactory.AbstractProducts;

namespace AspEFCore.AbstractFactory.AbstractInterface
{
    public interface IComputerFactory
    {
        public IBrand Brand();
        public IProcessor Processor();
        public ISystemType SystemType();

    }
}
