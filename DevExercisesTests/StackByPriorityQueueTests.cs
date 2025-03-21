using DevExercises;

namespace DevExercisesTests
{
    /// <summary>
    /// Test class to validate functionality of the <see cref="StackByPriorityQueue"/> class.
    /// </summary>
    [TestClass]
    public class StackByPriorityQueueTests
    {
        [TestMethod]
        public void Test_PushAndPop()
        {
            // Arrange
            var stack = new StackByPriorityQueue();

            // Act
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            int? poppedElement;

            // Assert
            poppedElement = stack.Pop(); // Should be 3 (last in)
            Assert.AreEqual(3, poppedElement);

            poppedElement = stack.Pop(); // Should be 2
            Assert.AreEqual(2, poppedElement);

            poppedElement = stack.Pop(); // Should be 1 (first in)
            Assert.AreEqual(1, poppedElement);
        }

        [TestMethod]
        public void Test_IsEmpty()
        {
            // Arrange
            var stack = new StackByPriorityQueue();

            // Act & Assert
            Assert.IsTrue(stack.IsEmpty()); // Initially empty

            stack.Push(1);

            Assert.IsFalse(stack.IsEmpty()); // Not empty after pushing an element
        }

        [TestMethod]
        public void Test_Size()
        {
            // Arrange
            var stack = new StackByPriorityQueue();

            // Act
            stack.Push(1);
            stack.Push(2);

            int size;

            // Assert
            size = stack.Size();
            Assert.AreEqual(2, size); // Size should be 2

            stack.Pop();

            size = stack.Size();
            Assert.AreEqual(1, size); // Size should be 1 after one pop
        }

        [TestMethod]
        public void Test_PopOnEmptyStack()
        {
            // Arrange
            var stack = new StackByPriorityQueue();

            // Act & Assert
            try
            {
                stack.Pop(); // Should throw an exception as the stack is empty
                Assert.Fail("Expected InvalidOperationException was not thrown.");
            }
            catch (InvalidOperationException ex)
            {
                Assert.AreEqual("Empty stack.", ex.Message);
            }
        }

        [TestMethod]
        public void Test_ResizeArray()
        {
            // Arrange
            var stack = new StackByPriorityQueue();

            // Act
            for (int i = 0; i < 10; i++)
            {
                stack.Push(i); // Push more elements than the initial capacity to trigger resizing
            }

            int size;

            // Assert
            size = stack.Size();
            Assert.AreEqual(10, size); // Size should be 10 after pushing 10 elements

            for (int i = 9; i >= 0; i--)
            {
                var poppedElement = stack.Pop(); // Should pop in reverse order
                Assert.AreEqual(i, poppedElement);
            }

            Assert.IsTrue(stack.IsEmpty()); // Stack should be empty after popping all elements
        }

        [TestMethod]
        public void Test_PushPopWithRepetitiveData()
        {
            // Arrange
            var stack = new StackByPriorityQueue();
            int?[] data = { 5, 5, 5 };

            // Act
            foreach (int? item in data)
            {
                stack.Push(item);
            }

            for (int i = data.Length - 1; i >= 0; i--)
            {
                int? poppedElement = stack.Pop();
                Assert.AreEqual(data[i], poppedElement);
            }
        }

        [TestMethod]
        public void Test_PushPopWithRandomData()
        {
            // Arrange
            var stack = new StackByPriorityQueue();
            Random random = new Random();
            const int dataSize = 100;
            int?[] data = new int?[dataSize];

            for (int i = 0; i < dataSize; i++)
            {
                if (random.Next(2) == 0)
                    data[i] = null;
                else
                    data[i] = random.Next(1, 100);
            }

            // Act
            foreach (int? item in data)
            {
                stack.Push(item);
            }

            for (int i = dataSize - 1; i >= 0; i--)
            {
                int? poppedElement = stack.Pop();
                Assert.AreEqual(data[i], poppedElement);
            }
        }
    }
}
