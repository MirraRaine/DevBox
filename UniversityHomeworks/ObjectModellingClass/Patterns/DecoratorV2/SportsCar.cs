namespace UniversityHomeworks.ObjectModellingClass.Patterns.DecoratorV2
{
    public class SportsCar : CarDecorator
    {
        public SportsCar(Car c) : base(c) { }

        public void Assemble()
        {
            car.Assemble();
            Console.WriteLine(" Adding features of Sports Car.");
        }
    }
}
