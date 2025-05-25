namespace UniversityHomeworks.ObjectModellingClass.Patterns.DecoratorV2
{
    public class CarDecorator : Car
    {
        protected Car car;

        public CarDecorator(Car c)
        {
            this.car = c;
        }

        public void Assemble()
        {
            this.car.Assemble();
        }

    }
}
