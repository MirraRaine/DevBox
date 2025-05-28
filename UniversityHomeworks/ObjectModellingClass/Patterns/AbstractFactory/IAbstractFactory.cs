namespace UniversityHomeworks.ObjectModellingClass.Patterns.AbstractFactory
{
    /// <summary>
    /// Represents the Abstract Factory interface that declares methods for creating abstract product families.
    /// </summary>
    public interface IAbstractFactory
    {
        /// <summary>
        /// Creates and returns an instance of a class implementing IColor.
        /// </summary>
        /// <returns></returns>
        IColor GetColor();

        /// <summary>
        /// Creates and returns an instance of a class implementing IShape.
        /// </summary>
        /// <returns></returns>
        IShape GetShape();
    }
}