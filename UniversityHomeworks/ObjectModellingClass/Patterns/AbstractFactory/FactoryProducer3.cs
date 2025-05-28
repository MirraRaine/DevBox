namespace UniversityHomeworks.ObjectModellingClass.Patterns.AbstractFactory
{
    /// <summary>
    /// Concrete factory that creates a `Green` color and a `Circle` shape.
    /// </summary>
    public class FactoryProducer3 : IAbstractFactory
    {
        public IColor GetColor()
        {
            return new Green();
        }

        public IShape GetShape()
        {
            return new Circle();
        }
    }
}
