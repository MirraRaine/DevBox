namespace UniversityHomeworks.ObjectModellingClass.Patterns.Facade
{
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Circle::draw()");
        }
    }
}
