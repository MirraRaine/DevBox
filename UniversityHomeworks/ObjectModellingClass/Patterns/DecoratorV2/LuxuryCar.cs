namespace UniversityHomeworks.ObjectModellingClass.Patterns.DecoratorV2
{
    public class LuxuryCar : CarDecorator
    {
        public LuxuryCar(Car c) : base(c) { }

        public void Assemble()
        {
            car.Assemble();
            Console.WriteLine(" Adding features of Luxury Car.");
        }
    }
}
