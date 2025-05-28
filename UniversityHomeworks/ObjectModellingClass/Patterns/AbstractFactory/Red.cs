namespace UniversityHomeworks.ObjectModellingClass.Patterns.AbstractFactory
{
    /// <summary>
    /// Concrete implementation of the `IColor` interface that represents the color red.
    /// </summary>
    public class Red : IColor
    {
        public string Fill()
        {
            return "Red";
        }
    }
}
