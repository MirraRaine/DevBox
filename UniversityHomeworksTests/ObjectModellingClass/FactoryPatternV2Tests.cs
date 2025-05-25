using UniversityHomeworks.ObjectModellingClass.Patterns.FactoryV2;

namespace UniversityHomeworksTests.ObjectModellingClass
{
    [TestClass]
    public class FactoryPatternV2Tests
    {
        [TestMethod]
        public void Client_Test()
        {
            Computer pc = ComputerFactory.GetComputer("pc", "2 GB", "500 GB", "2.4 GHz");
            Computer server = ComputerFactory.GetComputer("server", "16 GB", "1 TB", "2.9 GHz");
            Console.WriteLine("Factory PC Config::" + pc);
            Console.WriteLine("Factory Server Config::" + server);
        }
    }
}
