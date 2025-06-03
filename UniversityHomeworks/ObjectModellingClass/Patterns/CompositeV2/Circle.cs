namespace UniversityHomeworks.ObjectModellingClass.Patterns.CompositeV2
{
    /// <summary>
    /// Represents a simple circle shape (leaf in the composite structure).
    /// </summary>
    public class Circle : IShapeComponent
    {
        /// <inheritdoc />
        public string Draw(string fillColor)
        {
            return $"Drawing Circle with color {fillColor}";
        }
    }
}
