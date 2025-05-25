using UniversityHomeworks.ObjectModellingClass.Patterns.AbstractFactoryV2;

namespace UniversityHomeworksTests.ObjectModellingClass
{
    /// <summary>
    /// Test class to validate functionality of the <see cref="Patterns.AbstractFactory"/> pattern.
    /// </summary>
    [TestClass]
    public class AbstractFactoryPatternV2Tests
    {
        [TestMethod]
        public void Client_Test()
        {
            ComputerAbstractFactory pc = new PCFactory("2 GB", "500 GB", "2.4 GHz");
            ComputerAbstractFactory server = new ServerFactory("16 GB", "1 TB", "2.9 GHz");

            Console.WriteLine("AbstractFactory PC Config::" + pc);
            Console.WriteLine("AbstractFactory Server Config::" + server);
        }
    }
}
