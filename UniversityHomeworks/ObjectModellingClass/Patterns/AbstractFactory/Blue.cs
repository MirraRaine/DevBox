namespace UniversityHomeworks.ObjectModellingClass.Patterns.AbstractFactory
{
    /// <summary>
    /// Concrete implementation of the `IColor` interface that represents the color blue.
    /// </summary>
    public class Blue : IColor
    {
        public string Fill()
        {
            return "Blue";
        }
    }
}
