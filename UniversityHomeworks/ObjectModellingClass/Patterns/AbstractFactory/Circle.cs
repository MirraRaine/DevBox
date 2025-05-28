namespace UniversityHomeworks.ObjectModellingClass.Patterns.AbstractFactory
{
    /// <summary>
    /// Concrete implementation of the `IShape` interface that represents a circle shape.
    /// </summary>
    public class Circle : IShape
    {
        public string Draw()
        {
            return "Circle";
        }
    }
}
