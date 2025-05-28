namespace UniversityHomeworks.ObjectModellingClass.Patterns.AbstractFactoryV2
{
    /// <summary>
    /// Declares a factory interface for creating `Computer` objects.
    /// Enables decoupling of object creation from its implementation.
    /// </summary>
    public interface IComputerAbstractFactory
    {
        /// <summary>
        /// Creates and returns a new `Computer` object.
        /// </summary>
        public Computer CreateComputer();

        /// <summary>
        /// Returns a string representation of the configuration this factory will produce.
        /// </summary>
        public string ToString();
    }
}
