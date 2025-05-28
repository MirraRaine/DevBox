namespace UniversityHomeworks.ObjectModellingClass.Patterns.AbstractFactory
{
    /// <summary>
    /// Concrete factory that creates a `Red` color and a `Square` shape.
    /// </summary>
    public class FactoryProducer2 : IAbstractFactory
    {
        public IColor GetColor()
        {
            return new Red();
        }

        public IShape GetShape()
        {
            return new Square();
        }
    }
}
