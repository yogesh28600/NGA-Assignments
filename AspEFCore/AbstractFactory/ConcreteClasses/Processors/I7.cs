using AspEFCore.AbstractFactory.AbstractProducts;

namespace AspEFCore.AbstractFactory.ConcreteClasses.Processors
{
    public class I7 : IProcessor
    {
        public Enums.Processor GetProcessor()
        {
            return Enums.Processor.I7;
        }
    }
}
