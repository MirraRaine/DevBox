using UniversityHomeworks.ObjectModellingClass.Patterns.Proxy;

namespace UniversityHomeworksTests.ObjectModellingClass
{
    [TestClass]
    public class ProxyPatternTests
    {
        [TestMethod]
        public void Client_Test()
        {
            Image image = new ProxyImage("test_10mb.jpg");

            //image will be loaded from disk
            image.Display();
            Console.WriteLine("");

            //image will not be loaded from disk
            image.Display();
        }
    }
}
