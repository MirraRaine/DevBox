namespace UniversityHomeworks.ObjectModellingClass.Patterns.CompositeV2
{
    public class TriangleLeaf : ShapeComponent
    {
        public void Draw(string fillColor)
        {
            Console.WriteLine("Drawing TriangleLeaf with color " + fillColor);
        }
    }
}
