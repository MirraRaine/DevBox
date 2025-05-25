using UniversityHomeworks.ObjectModellingClass.Patterns.DecoratorV2;

namespace UniversityHomeworksTests.ObjectModellingClass
{
    [TestClass]
    public class DecoratorPatternV2Tests
    {
        [TestMethod]
        public void Client_Test()
        {
            Car sportsCar = new SportsCar(new BasicCar());
            sportsCar.Assemble();
            Console.WriteLine("\n*****");

            Car sportsLuxuryCar = new SportsCar(new LuxuryCar(new BasicCar()));
            sportsLuxuryCar.Assemble();
        }
    }
}
