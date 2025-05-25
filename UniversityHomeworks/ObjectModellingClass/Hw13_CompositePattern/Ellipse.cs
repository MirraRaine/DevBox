namespace UniversityHomeworks.ObjectModellingClass.Hw13_CompositePattern
{
    /// <summary>
    /// Ellipse is a Leaf
    /// Implements the component interface; represents end objects (e.g., files, buttons, graphics).
    /// </summary>
    public class Ellipse : IGraphic
    {
        /// <inheritdoc/>
        public void Print()
        {
            Console.WriteLine("Elipse");
        }
    }
}
