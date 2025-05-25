using UniversityHomeworks.ObjectModellingClass.Patterns.Facade;

namespace UniversityHomeworksTests.ObjectModellingClass
{
    [TestClass]
    public class FacadePatternTests
    {
        [TestMethod]
        public void Client_Test()
        {
            ShapeMaker shapeMaker = new ShapeMaker();

            shapeMaker.DrawCircle();
            shapeMaker.DrawRectangle();
            shapeMaker.DrawSquare();
        }
    }
}
