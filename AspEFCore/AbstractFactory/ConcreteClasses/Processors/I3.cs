using AspEFCore.AbstractFactory.AbstractProducts;

namespace AspEFCore.AbstractFactory.ConcreteClasses.Processors
{
    public class I3 : IProcessor
    {
        public Enums.Processor GetProcessor()
        {
            return Enums.Processor.I3;
        }
    }
}
