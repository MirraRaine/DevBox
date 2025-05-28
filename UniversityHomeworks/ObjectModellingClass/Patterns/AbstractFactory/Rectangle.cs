namespace UniversityHomeworks.ObjectModellingClass.Patterns.AbstractFactory
{
    /// <summary>
    /// Concrete implementation of the `IShape` interface that represents a rectangle shape.
    /// </summary>
    public class Rectangle : IShape
    {
        public string Draw()
        {
            return "Rectangle";
        }
    }
}
