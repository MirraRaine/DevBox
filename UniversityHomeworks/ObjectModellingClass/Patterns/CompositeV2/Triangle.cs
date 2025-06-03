namespace UniversityHomeworks.ObjectModellingClass.Patterns.CompositeV2
{
    /// <summary>
    /// Represents a simple triangle shape (leaf in the composite structure).
    /// </summary>
    public class Triangle : IShapeComponent
    {
        /// <inheritdoc />
        public string Draw(string fillColor)
        {
            return $"Drawing Triangle with color {fillColor}";
        }
    }
}
