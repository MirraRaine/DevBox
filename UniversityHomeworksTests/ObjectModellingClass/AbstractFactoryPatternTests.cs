using UniversityHomeworks.ObjectModellingClass.Patterns.AbstractFactory;

namespace UniversityHomeworksTests.ObjectModellingClass
{
    /// <summary>
    /// Test class to validate functionality of the <see cref="Patterns.AbstractFactory"/> pattern.
    /// </summary>
    [TestClass]
    public class AbstractFactoryPatternTests
    {
        [TestMethod]
        public void Test() 
        {

            // AbstractFactory shapeFactory = FactoryProducer.GetFactory("SHAPE");     //get shape factory
            //        Shape shape1 = shapeFactory.getShape("CIRCLE"); //get an object of Shape Circle
            //        shape1.draw();//call draw method of Shape Circle
            //        Shape shape2 = shapeFactory.getShape("RECTANGLE");//get an object of Shape Rectangle
            //        shape2.draw();//call draw method of Shape Rectangle
            //        Shape shape3 = shapeFactory.getShape("SQUARE");//get an object of Shape Square 
            //        shape3.draw();//call draw method of Shape Square
            //        AbstractFactory colorFactory = FactoryProducer.getFactory("COLOR");    //get color factory
            //        Color color1 = colorFactory.getColor("RED");//get an object of Color Red
            //        color1.fill();//call fill method of Red
            //        Color color2 = colorFactory.getColor("Green");//get an object of Color Green
            //        color2.fill();//call fill method of Green
            //        Color color3 = colorFactory.getColor("BLUE");//get an object of Color Blue
            //        color3.fill(); //call fill method of Color Blue
            //        

            IAbstractFactory fp = new FactoryProducer();
            Console.WriteLine(fp.GetColor());
            Console.WriteLine(fp.GetShape());
        }
    }
}
