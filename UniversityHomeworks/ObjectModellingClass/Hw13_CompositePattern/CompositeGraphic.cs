namespace UniversityHomeworks.ObjectModellingClass.Hw13_CompositePattern
{
    /// <summary>
    /// CompositeGraphic is a Composite
    /// Implements the component interface; contains and manages child components.
    /// </summary>
    public class CompositeGraphic : IGraphic
    {
        private List<IGraphic> graphics;

        public CompositeGraphic()
        {
            this.graphics = new List<IGraphic>();
        }

        public void Add(IGraphic graphic)
        {
            graphics.Add(graphic);
        }

        public void Remove(IGraphic graphic)
        {
            if (graphics.Count != 0)
            {
                graphics.Remove(graphic);
            }
        }

        /// <inheritdoc/>
        public void Print()
        {
            if (this.graphics.Count != 0)
            {
                foreach (var graphic in this.graphics)
                {
                    graphic.Print();
                }
            }
        }
    }
}
