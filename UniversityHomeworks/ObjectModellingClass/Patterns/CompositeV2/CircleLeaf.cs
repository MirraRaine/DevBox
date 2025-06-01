namespace UniversityHomeworks.ObjectModellingClass.Patterns.CompositeV2
{
    public class CircleLeaf : IShapeComponent
    {
        public void Draw(string fillColor)
        {
            Console.WriteLine("Drawing Circle with color " + fillColor);
            //throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
        }
    }
}
