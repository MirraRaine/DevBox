
using UniversityHomeworks.ObjectModellingClass.Patterns.Builder2;

namespace UniversityHomeworksTests.ObjectModellingClass
{
    [TestClass]
    public class BuilderPatternV2Tests
    {
        [TestMethod]
        public void Build_WithRequiredParametersOnly_ShouldCreateComputerWithDefaults()
        {
            // Arrange
            var builder = new ComputerBuilder("500GB", "8GB");

            // Act
            Computer comp = builder.Build();

            // Assert
            Assert.AreEqual("500GB", comp.HDD);
            Assert.AreEqual("8GB", comp.RAM);
            Assert.IsFalse(comp.IsBluetoothEnabled);
            Assert.IsFalse(comp.IsGraphicsCardEnabled);
        }

        [TestMethod]
        public void Build_WithAllParameters_ShouldCreateFullyConfiguredComputer()
        {
            // Arrange
            var builder = new ComputerBuilder("1TB", "16GB")
                            .SetBluetoothEnabled(true)
                            .SetGraphicsCardEnabled(true);

            // Act
            Computer comp = builder.Build();

            // Assert
            Assert.AreEqual("1TB", comp.HDD);
            Assert.AreEqual("16GB", comp.RAM);
            Assert.IsTrue(comp.IsBluetoothEnabled);
            Assert.IsTrue(comp.IsGraphicsCardEnabled);
        }

        [TestMethod]
        public void Build_DisableOptionalParameters_ShouldCreateComputerWithoutOptionalFeatures()
        {
            // Arrange
            var builder = new ComputerBuilder("256GB", "4GB")
                            .SetBluetoothEnabled(false)
                            .SetGraphicsCardEnabled(false);

            // Act
            Computer comp = builder.Build();

            // Assert
            Assert.AreEqual("256GB", comp.HDD);
            Assert.AreEqual("4GB", comp.RAM);
            Assert.IsFalse(comp.IsBluetoothEnabled);
            Assert.IsFalse(comp.IsGraphicsCardEnabled);
        }
    }
}
