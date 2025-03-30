using DevExercises;

namespace DevExercisesTests
{
    /// <summary>
    /// Test class to validate functionality of the <see cref="UnaryOperations"/> class.
    /// </summary>
    [TestClass]
    public class UnaryOperationsTests
    {
        /// <summary>
        /// Case: number = 8; k = 5
        /// Representation of 1 = 2^0 = 00000001
        /// (1 << (k-1)) this shifts 1 to k-1 positions
        /// k - 1 = 5 - 1 = 4
        /// 1 shift by 4 -> 00000001 ->  -> 00010000
        /// Representation of 8 is 2^3 = 00001000
        /// 00001000 AND 00010000 = 00000000
        /// AND gives 1 only for 1x1 -> in our case the result is 0
        /// </summary>
        [TestMethod]
        public void IsKthBitSet_BitIsNotSet_PositiveNumber()
        {
            // Arrange
            int number = 8;
            int k = 5;

            // Act
            bool isKBitSet = UnaryOperations.IsKthBitSet(number, k);
            Assert.IsFalse(isKBitSet);
        }

        /// <summary>
        /// Case: number = 8; k = 4
        /// Representation of 1 = 2^0 = 00000001
        /// (1 << (k-1)) this shifts 1 to k-1 positions
        /// k - 1 = 4 - 1 = 3
        /// 1 shift by 3 -> 00000001 ->  -> 00001000
        /// Representation of 8 is 2^3 = 00001000
        /// 00001000 AND 00001000 = 00001000 = 8
        /// AND gives 1 only for 1x1
        /// </summary>
        [TestMethod]
        public void IsKthBitSet_BitIsSet_PositiveNumber()
        {
            // Arrange
            int number = 8;
            int k = 4;

            // Act
            bool isKBitSet = UnaryOperations.IsKthBitSet(number, k);
            Assert.IsTrue(isKBitSet);
        }

        /// <summary>
        /// Case: number = 8 k = 0
        /// 8 = 2^3 = 00001000
        /// 4th element is set; it is 1
        /// Output: the 4th bit of 8 is set
        /// </summary>
        [TestMethod]
        public void IsKthBitSet_RaiseException()
        {
            try
            {
                UnaryOperations.IsKthBitSet(8, 0);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("k must be greater than or equal to 1 (Parameter 'k')", ex.Message);
            }
        }

        /// <summary>
        /// Case: number = -8 k=4
        /// Calculate Binary representation of 8
        /// 1. 8 = 2^3 = 0001000
        /// 2. Negate all bits = 1110111
        /// 3. Add 1: 1110111 + 00000001 = 1111 1000
        /// 
        /// 4th bit should be set
        /// </summary>
        [TestMethod]
        public void IsKthBitSet_BitNotSet_NegativeNumber()
        {
            Assert.IsTrue(UnaryOperations.IsKthBitSet(-8, 4));
        }

        /// <summary>
        /// Case: number = -8 k=2
        /// Calculate Binary representation of 8
        /// 1. 8 = 2^3 = 0001000
        /// 2. Negate all bits = 1110111
        /// 3. Add 1: 1110111 + 00000001 = 1111 1000
        /// 
        /// 2nd bit should be set
        /// </summary>
        [TestMethod]
        public void IsKthBitSet_BitIsSet_NegativeNumber()
        {
            Assert.IsFalse(UnaryOperations.IsKthBitSet(-8, 2));
        }

        /// <summary>
        /// Case: number = 115; k = 4 => not set
        /// 115 = 00000000 = 0(2^7) 1(2^6) 1(2^5) 1(2^4) 0(2^3) 0(2^2) 1(2^1) 1(2^0) = 01110011
        /// </summary>
        [TestMethod]
        public void IsKthBitSet_BitIsNotSet_PositiveNumber_115()
        {
            // Arrange
            int number = 115;
            int k = 4;

            // Act
            bool isKBitSet = UnaryOperations.IsKthBitSet(number, k);
            Assert.IsFalse(isKBitSet);
        }

        /// <summary>
        /// Case: number = 115; k = 7 => set
        /// 115 = 00000000 = 0(2^7) 1(2^6) 1(2^5) 1(2^4) 0(2^3) 0(2^2) 1(2^1) 1(2^0) = 01110011
        /// </summary>
        [TestMethod]
        public void IsKthBitSet_BitIsSet_PositiveNumber_115()
        {
            // Arrange
            int number = 115;
            int k = 7;

            // Act
            bool isKBitSet = UnaryOperations.IsKthBitSet(number, k);
            Assert.IsTrue(isKBitSet);
        }

        /// <summary>
        /// Case: number = -115; k = 5 => not set
        /// 115 = 00000000 = 0(2^7) 1(2^6) 1(2^5) 1(2^4) 0(2^3) 0(2^2) 1(2^1) 1(2^0) = 01110011
        /// Negate: 10001100
        /// +1: 10001101
        /// </summary>
        [TestMethod]
        public void IsKthBitSet_BitIsNotSet_PositiveNumber_Minus115()
        {
            // Arrange
            int number = -115;
            int k = 5;

            // Act
            bool isKBitSet = UnaryOperations.IsKthBitSet(number, k);
            Assert.IsFalse(isKBitSet);
        }

        /// <summary>
        /// Case: number = -115; k = 1 => set
        /// 115 = 00000000 = 0(2^7) 1(2^6) 1(2^5) 1(2^4) 0(2^3) 0(2^2) 1(2^1) 1(2^0) = 01110011
        /// Negate: 10001100
        /// +1: 10001101
        /// </summary>
        [TestMethod]
        public void IsKthBitSet_BitIsSet_PositiveNumber_Minus115()
        {
            // Arrange
            int number = -115;
            int k = 1;

            // Act
            bool isKBitSet = UnaryOperations.IsKthBitSet(number, k);
            Assert.IsTrue(isKBitSet);
        }

        /// <summary>
        /// Case: number = 1053; validate all kth elements on being set or not
        /// 1053 = 00000000 00000000 = 
        /// 0(2^15) 1(2^14) 1(2^13) 1(2^12) 0(2^11) 1(2^10) 0(2^9) 0(2^8) 0(2^7) 0(2^6) 0(2^5) 1(2^4) 1(2^3) 1(2^2) 0(2^1) 1(2^0)
        /// =    0b100 00011101
        /// Set bit = 1 3 4 5 11
        /// Not set bit = 2 6 7 8 9 10
        /// </summary>
        [TestMethod]
        public void IsKthBitSet_Variations_With_1053()
        {
            // Arrange
            int number = 1053;

            // Act & Assert

            // Set bit
            bool isKBitSet = UnaryOperations.IsKthBitSet(number, 1);
            Assert.IsTrue(isKBitSet);

            isKBitSet = UnaryOperations.IsKthBitSet(number, 3);
            Assert.IsTrue(isKBitSet);

            isKBitSet = UnaryOperations.IsKthBitSet(number, 4);
            Assert.IsTrue(isKBitSet);

            isKBitSet = UnaryOperations.IsKthBitSet(number, 5);
            Assert.IsTrue(isKBitSet);

            isKBitSet = UnaryOperations.IsKthBitSet(number, 11);
            Assert.IsTrue(isKBitSet);

            // Not set bit
            isKBitSet = UnaryOperations.IsKthBitSet(number, 2);
            Assert.IsFalse(isKBitSet);

            isKBitSet = UnaryOperations.IsKthBitSet(number, 6);
            Assert.IsFalse(isKBitSet);

            isKBitSet = UnaryOperations.IsKthBitSet(number, 7);
            Assert.IsFalse(isKBitSet);

            isKBitSet = UnaryOperations.IsKthBitSet(number, 8);
            Assert.IsFalse(isKBitSet);

            isKBitSet = UnaryOperations.IsKthBitSet(number, 9);
            Assert.IsFalse(isKBitSet);

            isKBitSet = UnaryOperations.IsKthBitSet(number, 10);
            Assert.IsFalse(isKBitSet);
        }
    }
}
