using DevExercises;

namespace DevExercisesTests
{
    /// <summary>
    /// Test class to validate functionality of the <see cref="StringDecoder"/> class.
    /// Input cases that are not handled in the StringDecoder: '2[ab]3[cd', '0[ab]', 2[a2[
    /// </summary>
    [TestClass]
    public class StringDecoderTests
    {
        [TestMethod]
        public void Decode_BasicEncoding_ReturnsDecodedString()
        {
            // Arrange
            string encodedString = "2[ab]";

            // Act
            string decodedString = encodedString.Decode();

            // Assert
            Assert.AreEqual("abab", decodedString, "The decoded string should be 'abab'.");
        }

        [TestMethod]
        public void Decode_NestedEncoding_ReturnsDecodedString()
        {
            // Arrange
            string encodedString = "2[a5[abc2[ab]]]";

            // Act
            string decodedString = encodedString.Decode();

            // Assert
            Assert.AreEqual("aabcabababcabababcabababcabababcababaabcabababcabababcabababcabababcabab", decodedString, "The decoded string should be 'aabcabababcabababcabababcabababcababaabcabababcabababcabababcabababcabab'.");
        }

        [TestMethod]
        public void Decode_NestedEncoding_NoClosingBracketString_ReturnsDecodedString()
        {
            // Arrange
            string encodedString = "2[a2[b";

            // Act
            string decodedString = encodedString.Decode();

            // Assert
            Assert.AreEqual("abbabb", decodedString, "The decoded string should be 'abab'.");
        }

        [TestMethod]
        public void Decode_EmptyString_ThrowsInvalidOperationException()
        {
            // Arrange
            string encodedString = "";

            try
            {
                // Act
                encodedString.Decode();

                // Assert: If the code reaches here, it means no exception was thrown
                Assert.Fail("Expected InvalidOperationException to be thrown for empty input.");
            }
            catch (InvalidOperationException ex)
            {
                // Assert: Check if the correct exception is thrown
                Assert.AreEqual("Stacks must be properly populated with data.", ex.Message);
            }
        }

        [TestMethod]
        public void Decode_ValidInputWithZeroReplication_ThrowsInvalidOperationException()
        {
            // Arrange
            string encodedString = "0[ab]";

            try
            {
                // Act
                encodedString.Decode();

                // Assert: If the code reaches here, it means no exception was thrown
                Assert.Fail("Expected InvalidOperationException to be thrown for invalid input.");
            }
            catch (InvalidOperationException ex)
            {
                // Assert: Check if the correct exception is thrown
                Assert.AreEqual("Invalid numeric value in stack.", ex.Message);
            }
        }
    }
}
