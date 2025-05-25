
namespace UniversityHomeworks.ObjectModellingClass.Patterns.AbstractFactory
{
    public class FactoryProducer : IAbstractFactory
    {
        public IColor GetColor()
        {
            return new Red();

        }

        public IShape GetShape()
        {
            return new Rectangle();
        }
    }
}
