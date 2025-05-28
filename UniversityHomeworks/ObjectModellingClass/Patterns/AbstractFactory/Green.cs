namespace UniversityHomeworks.ObjectModellingClass.Patterns.AbstractFactory
{
    /// <summary>
    /// Concrete implementation of the `IColor` interface that represents the color green.
    /// </summary>
    public class Green : IColor
    {
        public string Fill()
        {
            return "Green";
        }
    }
}
