using System.Text;

namespace UniversityHomeworks.ObjectModellingClass.Patterns.CompositeV2
{
    /// <summary>
    /// Represents a composite drawing that can hold and operate on multiple shapes.
    /// </summary>
    public class Drawing : IShapeComponent
    {
        private readonly List<IShapeComponent> _shapes = new();

        /// <summary>
        /// Adds a shape to the drawing.
        /// </summary>
        /// <param name="shape">The shape to add.</param>
        public void Add(IShapeComponent shape)
        {
            _shapes.Add(shape);
        }

        /// <summary>
        /// Removes a shape from the drawing.
        /// </summary>
        /// <param name="shape">The shape to remove.</param>
        public void Remove(IShapeComponent shape)
        {
            _shapes.Remove(shape);
        }

        /// <summary>
        /// Clears all shapes from the drawing.
        /// </summary>
        public void Clear()
        {
            _shapes.Clear();
        }

        /// <inheritdoc />
        public string Draw(string fillColor)
        {
            var result = new StringBuilder();
            result.AppendLine("Drawing composite with color: " + fillColor);

            foreach (var shape in _shapes)
            {
                result.AppendLine(shape.Draw(fillColor));
            }

            return result.ToString().TrimEnd();
        }
    }
}
