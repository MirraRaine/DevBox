
namespace UniversityHomeworks.ObjectModellingClass.Patterns.AbstractFactory
{
    /// <summary>
    /// Concrete factory that creates a `Blue` color and a `Rectangle` shape.
    /// </summary>
    public class FactoryProducer1 : IAbstractFactory
    {
        public IColor GetColor()
        {
            return new Blue();
        }

        public IShape GetShape()
        {
            return new Rectangle();
        }
    }
}
