namespace UniversityHomeworks.ObjectModellingClass.Patterns.Facade
{
    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Rectangle::draw()");
        }
    }
}
