using AspEFCore.AbstractFactory.AbstractProducts;

namespace AspEFCore.AbstractFactory.ConcreteClasses.Processors
{
    public class I5 : IProcessor
    {
        public Enums.Processor GetProcessor()
        {
            return Enums.Processor.I5;
        }
    }
}
