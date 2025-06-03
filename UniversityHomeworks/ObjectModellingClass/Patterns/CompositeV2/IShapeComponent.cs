namespace UniversityHomeworks.ObjectModellingClass.Patterns.CompositeV2
{
    /// <summary>
    /// Defines the common interface for all shape components (leaves and composites).
    /// </summary>
    public interface IShapeComponent
    {
        /// <summary>
        /// Draws the shape using the given fill color and returns the output.
        /// </summary>
        /// <param name="fillColor">The fill color to apply.</param>
        /// <returns>A string representing the drawing operation.</returns>
        string Draw(string fillColor);
    }
}
