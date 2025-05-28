namespace UniversityHomeworks.ObjectModellingClass.Patterns.AbstractFactory
{
    /// <summary>
    /// Represents an abstract product for color-related behavior.
    /// </summary>
    public interface IColor
    {
        /// <summary>
        /// Fills the shape or object with the corresponding color.
        /// </summary>
        string Fill();
    }
}
