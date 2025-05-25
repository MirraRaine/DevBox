namespace UniversityHomeworks.ObjectModellingClass.Patterns.CompositeV2
{
    //composite
    public class Drawing : ShapeComponent
    {
        //collection of Shapes
        private List<ShapeComponent> shapes = new List<ShapeComponent>();

        public void Draw(String fillColor)
        {
            foreach (ShapeComponent sh in shapes)
            {
                sh.Draw(fillColor);
            }
        }

        //Adding shape to drawing
        public void Add(ShapeComponent s)
        {
            this.shapes.Add(s);
        }

        //removing shape from drawing
        public void Remove(ShapeComponent s)
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
