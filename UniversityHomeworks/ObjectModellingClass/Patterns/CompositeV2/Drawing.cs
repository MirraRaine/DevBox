namespace UniversityHomeworks.ObjectModellingClass.Patterns.CompositeV2
{
    //composite
    public class Drawing : IShapeComponent
    {
        //collection of Shapes
        private List<IShapeComponent> shapes = new List<IShapeComponent>();

        public void Draw(String fillColor)
        {
            foreach (IShapeComponent sh in shapes)
            {
                sh.Draw(fillColor);
            }
        }

        //Adding shape to drawing
        public void Add(IShapeComponent s)
        {
            this.shapes.Add(s);
        }

        //removing shape from drawing
        public void Remove(IShapeComponent s)
        {
            shapes.Remove(s);
        }

        //removing all the shapes
        public void Clear()
        {
            Console.WriteLine("Clearing all the shapes from drawing");
            this.shapes.Clear();
        }
    }
}
