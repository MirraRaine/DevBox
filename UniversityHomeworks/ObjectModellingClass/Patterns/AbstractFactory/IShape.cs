namespace UniversityHomeworks.ObjectModellingClass.Patterns.AbstractFactory
{
    /// <summary>
    /// Represents an abstract product for shape-related behavior.
    /// </summary>
    public interface IShape
    {
        /// <summary>
        /// Draws the shape defined by the implementing class.
        /// </summary>
        string Draw();
    }
}
