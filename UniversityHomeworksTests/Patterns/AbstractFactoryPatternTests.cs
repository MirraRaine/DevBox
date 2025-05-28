using UniversityHomeworks.ObjectModellingClass.Patterns.AbstractFactory;

namespace UniversityHomeworksTests.Patterns
{
    /// <summary>
    /// Test class to validate functionality of the <see cref="Patterns.AbstractFactory"/> pattern.
    /// </summary>
    [TestClass]
    public class AbstractFactoryPatternTests
    {
        [TestMethod]
        public void Circle_Draw_ReturnsCircle()
        {
            IShape shape = new Circle();
            string result = shape.Draw();
            Assert.AreEqual("Circle", result);
        }

        [TestMethod]
        public void Square_Draw_ReturnsSquare()
        {
            IShape shape = new Square();
            string result = shape.Draw();
            Assert.AreEqual("Square", result);
        }

        [TestMethod]
        public void Rectangle_Draw_ReturnsRectangle()
        {
            IShape shape = new Rectangle();
            string result = shape.Draw();
            Assert.AreEqual("Rectangle", result);
        }

        [TestMethod]
        public void Red_Fill_ReturnsRed()
        {
            IColor color = new Red();
            string result = color.Fill();
            Assert.AreEqual("Red", result);
        }

        [TestMethod]
        public void Blue_Fill_ReturnsBlue()
        {
            IColor color = new Blue();
            string result = color.Fill();
            Assert.AreEqual("Blue", result);
        }

        [TestMethod]
        public void Green_Fill_ReturnsGreen()
        {
            IColor color = new Green();
            string result = color.Fill();
            Assert.AreEqual("Green", result);
        }

        [TestMethod]
        public void FactoryProducer1_ReturnsBlueAndRectangle()
        {
            IAbstractFactory factory = new FactoryProducer1();
            Assert.AreEqual("Blue", factory.GetColor().Fill());
            Assert.AreEqual("Rectangle", factory.GetShape().Draw());
        }

        [TestMethod]
        public void FactoryProducer2_ReturnsRedAndSquare()
        {
            IAbstractFactory factory = new FactoryProducer2();
            Assert.AreEqual("Red", factory.GetColor().Fill());
            Assert.AreEqual("Square", factory.GetShape().Draw());
        }

        [TestMethod]
        public void FactoryProducer3_ReturnsGreenAndCircle()
        {
            IAbstractFactory factory = new FactoryProducer3();
            Assert.AreEqual("Green", factory.GetColor().Fill());
            Assert.AreEqual("Circle", factory.GetShape().Draw());
        }
    }
}
