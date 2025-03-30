using DevExercises;

namespace DevExercisesTests
{
    /// <summary>
    /// Test class to validate functionality of the <see cref="PerfectNumberChecker"/> class.
    /// </summary>
    [TestClass]
    public class PerfectNumberCheckerTests
    {
        [TestMethod]
        public void TestPerfectNumber_6()
        {
            // 6 is a perfect number (1 + 2 + 3 = 6)
            bool result = PerfectNumberChecker.IsPerfectNumber(6);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestPerfectNumber_28()
        {
            // 28 is a perfect number (1 + 2 + 4 + 7 + 14 = 28)
            bool result = PerfectNumberChecker.IsPerfectNumber(28);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestNotPerfectNumber_8()
        {
            // 8 is not a perfect number (1 + 2 + 4 != 8)
            bool result = PerfectNumberChecker.IsPerfectNumber(8);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestZero()
        {
            // 0 is not a perfect number
            bool result = PerfectNumberChecker.IsPerfectNumber(0);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestNegativeNumber()
        {
            // Negative numbers should return false, as negative numbers cannot be perfect numbers
            bool result = PerfectNumberChecker.IsPerfectNumber(-6);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestOne()
        {
            // 1 is not a perfect number (its divisors are just 1, and it doesn't equal itself)
            bool result = PerfectNumberChecker.IsPerfectNumber(1);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestLargePerfectNumber_496()
        {
            // 496 is a perfect number (1 + 2 + 4 + 8 + 16 + 31 + 62 + 124 + 248 = 496)
            bool result = PerfectNumberChecker.IsPerfectNumber(496);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestLargeNonPerfectNumber_1000()
        {
            // 1000 is not a perfect number
            bool result = PerfectNumberChecker.IsPerfectNumber(1000);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestEvenPerfectNumber_8128()
        {
            // 8128 is a perfect number
            bool result = PerfectNumberChecker.IsPerfectNumber(8128);
            Assert.IsTrue(result);
        }
    }
}
