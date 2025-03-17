using DevExercises;

namespace DevExercisesTests
{
    /// <summary>
    /// Test class to validate functionality of the <see cref="StackTrackMaxElement"/> class.
    /// </summary>
    [TestClass]
    public sealed class StackTrackMaxElementTests
    {
        private StackTrackMaxElement? stack;

        [TestInitialize]
        public void Initialize()
        {
            stack = new StackTrackMaxElement();
        }

        [TestMethod]
        public void Test_PushAndPopStackElements()
        {
            // Arrange
            int[] elements = { 4, 19, 7, 14, 20 };
            int[] expectedElementsOnStack = { 20, 14, 7, 19, 4 };

            // Act
            foreach (int element in elements)
            {
                this.stack?.Push(element);
            }

            // Assert
            int expectedStackSize = elements.Length;
            Assert.IsNotNull(this.stack);
            Assert.AreEqual(expectedStackSize, this.stack.Size());
            Assert.AreEqual(expectedStackSize, this.stack.GetTrackingMaximumElementsList().Count);

            for (int i = 0; i < expectedStackSize; i++)
            {
                Assert.AreEqual(expectedElementsOnStack[i], stack.Pop());
            }
        }

        [TestMethod]
        public void Test_PushAndPopAndTrackMaxStackElements()
        {
            // Arrange
            Assert.IsNotNull(this.stack);
            Assert.IsTrue(this.stack.IsEmpty());
            int[] elements = { 4, 19, 7, 14, 20 };
            foreach (int element in elements)
            {
                this.stack.Push(element);
            }
            var expectedTrackingListAfterPush = new List<int> { 4, 19, 19, 19, 20 };
            Assert.AreEqual(expectedTrackingListAfterPush.Count, this.stack?.GetTrackingMaximumElementsList().Count);

            // Act
            Assert.IsNotNull(this.stack);
            int poppedElement = this.stack.Pop();

            // Assert
            Assert.AreEqual(20, poppedElement);
            expectedTrackingListAfterPush = new List<int> { 4, 19, 19, 19 };

            Assert.AreEqual(expectedTrackingListAfterPush.Count, this.stack.GetTrackingMaximumElementsList().Count);
            for (int i = 0; i < expectedTrackingListAfterPush.Count; i++)
            {
                Assert.AreEqual(expectedTrackingListAfterPush[i], this.stack.GetTrackingMaximumElementsList()[i]);
            }

            poppedElement = this.stack.Pop();
            Assert.AreEqual(14, poppedElement);
            expectedTrackingListAfterPush = new List<int> { 4, 19, 19 };
            Assert.AreEqual(expectedTrackingListAfterPush.Count, this.stack.GetTrackingMaximumElementsList().Count);
            for (int i = 0; i < expectedTrackingListAfterPush.Count; i++)
            {
                Assert.AreEqual(expectedTrackingListAfterPush[i], this.stack.GetTrackingMaximumElementsList()[i]);
            }

            poppedElement = this.stack.Pop();
            Assert.AreEqual(7, poppedElement);
            expectedTrackingListAfterPush = new List<int> { 4, 19 };
            Assert.AreEqual(expectedTrackingListAfterPush.Count, this.stack.GetTrackingMaximumElementsList().Count);
            for (int i = 0; i < expectedTrackingListAfterPush.Count; i++)
            {
                Assert.AreEqual(expectedTrackingListAfterPush[i], this.stack.GetTrackingMaximumElementsList()[i]);
            }
        }

        [TestMethod]
        public void Test_PushAndPeekStackElements()
        {
            // Arrange
            Assert.IsNotNull(this.stack);
            Assert.IsTrue(this.stack.IsEmpty());
            int[] elements = { 4, 19, 7 };
            foreach (int element in elements)
            {
                this.stack?.Push(element);
            }

            // Act
            Assert.IsNotNull(this.stack);
            int topElement = this.stack.Peek();

            // Assert
            Assert.AreEqual(7, topElement);
        }

        [TestMethod]
        public void Test_StackSize()
        {
            // Arrange
            int[] elements = { 4, 19, 7 };
            foreach (int element in elements)
            {
                this.stack?.Push(element);
            }

            // Act & Assert
            Assert.IsNotNull(this.stack);
            Assert.AreEqual(3, this.stack.Size());
            stack.Pop();
            Assert.AreEqual(2, this.stack.Size());
        }

        [TestMethod]
        public void Test_StackIsEmpty()
        {
            // Arrange
            Assert.IsNotNull(this.stack);
            Assert.IsTrue(this.stack.IsEmpty());

            // Act & Assert
            Assert.IsTrue(stack.IsEmpty());
            stack.Push(4);
            Assert.IsFalse(stack.IsEmpty());
            stack.Pop();
            Assert.IsTrue(stack.IsEmpty());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Test_Pop_ThrowsExceptionWhenStackEmpty()
        {
            // Arrange
            Assert.IsNotNull(this.stack);
            Assert.IsTrue(this.stack.IsEmpty());

            // Act & Assert
            stack.Pop(); // Should throw InvalidOperationException since the stack is empty
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Test_Peek_ThrowsExceptionWhenStackEmpty()
        {
            // Arrange
            Assert.IsNotNull(this.stack);
            Assert.IsTrue(this.stack.IsEmpty());

            // Act & Assert
            stack.Peek(); // Should throw InvalidOperationException since the stack is empty
        }

        [TestMethod]
        public void Test_PushAndTrackCurrentMaximum()
        {
            // Arrange
            Assert.IsNotNull(this.stack);
            Assert.IsTrue(this.stack.IsEmpty());
            this.stack?.Push(4);
            this.stack?.Push(19);

            // Act
            Assert.IsNotNull(this.stack);
            int maxAfterFirstPop = this.stack.Pop();
            stack.Push(20);
            int maxAfterSecondPush = stack.Peek();

            // Assert
            Assert.AreEqual(19, maxAfterFirstPop); // The top element before popping 20 was 19
            Assert.AreEqual(20, maxAfterSecondPush); // After pushing 20, the new max is 20
        }
    }
}
