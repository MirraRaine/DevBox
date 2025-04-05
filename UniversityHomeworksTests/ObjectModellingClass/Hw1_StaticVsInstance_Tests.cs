using UniversityHomeworks.ObjectModellingClass;

namespace UniversityHomeworksTests.ObjectModellingClass
{
    /// <summary>
    /// Test class to validate functionality of the <see cref="Hw1_StaticVsInstance"/> class.
    /// </summary>
    [TestClass]
    public sealed class Hw1_StaticVsInstance_Tests
    {
        [TestMethod]
        public void GetsTrueAlways_ReturnsTrue()
        {
            // Arrange
            var hw = new Hw1_StaticVsInstance();

            // Act
            bool result = hw.GetsTrueAlways();

            // Assert
            for (int i = 0; i < 10; i++)
            {
                Assert.IsTrue(result);
            }
        }

        [TestMethod]
        public void GetsFalseAlways_ReturnsFalse()
        {
            // Act
            bool result = Hw1_StaticVsInstance.GetsFalseAlways();

            // Assert
            for (int i = 0; i < 10; i++)
            {
                Assert.IsFalse(result);
            }
        }

        [TestMethod]
        public void IncrementsAndReturnsInstance_IncreasesCorrectlyForSingleInstance()
        {
            // Arrange
            var hw = new Hw1_StaticVsInstance();
            int firstCallResult, secondCallResult;

            // Act
            firstCallResult = hw.IncrementsAndReturnsInstance();
            secondCallResult = hw.IncrementsAndReturnsInstance();

            // Assert
            Assert.AreEqual(1, firstCallResult);
            Assert.AreEqual(2, secondCallResult);
        }

        [TestMethod]
        public void IncrementsAndReturnsStaticVar_IncreasesCorrectlyForMultipleInstances()
        {
            // Arrange
            var hw = new Hw1_StaticVsInstance();
            var hw2 = new Hw1_StaticVsInstance();

            int firstInstanceFirstCall, firstInstanceSecondCall;
            int secondInstanceFirstCall, secondInstanceSecondCall;

            // Act
            firstInstanceFirstCall = hw.IncrementsAndReturnsStaticVar();  // Should return 1
            secondInstanceFirstCall = hw2.IncrementsAndReturnsStaticVar(); // Should return 2, not 1, even though it is called from hw2 for the first time
            firstInstanceSecondCall = hw.IncrementsAndReturnsStaticVar();  // Should return 3, even though it is called 2nd time from hw; it was also called from hw2
            secondInstanceSecondCall = hw2.IncrementsAndReturnsStaticVar(); // Should return 4, because it was called 2 times from hw, and 1 time from hw2; this is the 4th call

            // Assert
            Assert.AreEqual(1, firstInstanceFirstCall);
            Assert.AreEqual(2, secondInstanceFirstCall);
            Assert.AreEqual(3, firstInstanceSecondCall);
            Assert.AreEqual(4, secondInstanceSecondCall);
        }
    }
}
