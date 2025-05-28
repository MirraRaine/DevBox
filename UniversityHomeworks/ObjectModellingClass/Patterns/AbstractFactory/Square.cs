namespace UniversityHomeworks.ObjectModellingClass.Patterns.AbstractFactory
{
    /// <summary>
    /// Concrete implementation of the `IShape` interface that represents a square shape.
    /// </summary>
    public class Square : IShape
    {
        public string Draw()
        {
            return "Square";
        }
    }
}
