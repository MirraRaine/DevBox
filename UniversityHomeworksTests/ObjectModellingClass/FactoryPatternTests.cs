using UniversityHomeworks.ObjectModellingClass.Patterns.Factory;

namespace UniversityHomeworksTests.ObjectModellingClass
{
    [TestClass]
    public class FactoryPatternTests
    {
        [TestMethod]
        public void Client_Test()
        {
            ShapeFactory shapeFactory = new ShapeFactory();

            //get an object of Circle and call its Draw method.
            IShape shape1 = shapeFactory.GetShape("CIRCLE");

            //call Draw method of Circle
            shape1.Draw();

            //get an object of Rectangle and call its Draw method.
            IShape shape2 = shapeFactory.GetShape("RECTANGLE");

            //call Draw method of Rectangle
            shape2.Draw();

            //get an object of Square and call its Draw method.
            IShape shape3 = shapeFactory.GetShape("SQUARE");

            //call Draw method of circle
            shape3.Draw();
        }
    }
}
