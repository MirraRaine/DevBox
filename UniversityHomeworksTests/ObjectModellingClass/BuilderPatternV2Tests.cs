
using UniversityHomeworks.ObjectModellingClass.Patterns.Builder2;

namespace UniversityHomeworksTests.ObjectModellingClass
{
    [TestClass]
    public class BuilderPatternV2Tests
    {
        [TestMethod]
        public void Client_Test()
        {
            //Using builder to get the object in a single line of code and 
            //without any inconsistent state or arguments management issues     
            Comp comp = new ComputerBuilder("500 GB", "2 GB").SetBluetoothEnabled(true).SetGraphicsCardEnabled(true).Build();
        }
    }
}
