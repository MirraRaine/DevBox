using UniversityHomeworks.ObjectModellingClass.Patterns.AdapterV2;

namespace UniversityHomeworksTests.Patterns
{
    [TestClass]
    public class AdapaterPatternV2Tests
    {
        [TestMethod]
        public void ChefAdapterByInheritance_MakeBreakfast_ReturnsGasket()
        {
            // Arrange
            IChief chief = new ChefAdapterByInheritance();

            // Act
            var result = chief.MakeBreakfast();

            // Assert
            Assert.AreEqual("Gasket", result);
        }

        [TestMethod]
        public void ChefAdapterByInheritance_MakeLunch_ReturnsPipe()
        {
            // Arrange
            IChief chief = new ChefAdapterByInheritance();

            // Act
            var result = chief.MakeLunch();

            // Assert
            Assert.AreEqual("Pipe", result);
        }

        [TestMethod]
        public void ChefAdapterByInheritance_MakeDinner_ReturnsScrewNut()
        {
            // Arrange
            IChief chief = new ChefAdapterByInheritance();

            // Act
            var result = chief.MakeDinner();

            // Assert
            Assert.AreEqual("ScrewNut", result);
        }
    }

    [TestClass]
    public class ChefAdapterByCompositionTests
    {
        [TestMethod]
        public void ChefAdapterByComposition_MakeBreakfast_ReturnsGasket()
        {
            // Arrange
            IChief chief = new ChefAdapterByComposition();

            // Act
            var result = chief.MakeBreakfast();

            // Assert
            Assert.AreEqual("Gasket", result);
        }

        [TestMethod]
        public void ChefAdapterByComposition_MakeLunch_ReturnsPipe()
        {
            // Arrange
            IChief chief = new ChefAdapterByComposition();

            // Act
            var result = chief.MakeLunch();

            // Assert
            Assert.AreEqual("Pipe", result);
        }

        [TestMethod]
        public void ChefAdapterByComposition_MakeDinner_ReturnsScrewNut()
        {
            // Arrange
            IChief chief = new ChefAdapterByComposition();

            // Act
            var result = chief.MakeDinner();

            // Assert
            Assert.AreEqual("ScrewNut", result);
        }
    }
}
