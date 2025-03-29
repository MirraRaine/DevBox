using DevExercises;

namespace DevExercisesTests
{
    /// <summary>
    /// Test class to validate functionality of the <see cref="GenericStackT"/> class.
    /// </summary>
    [TestClass]
    public class GenericStackTests
    {
        private readonly IStack<long> stack = new GenericStack<long>();

        [TestMethod]
        public void Test_Push_Pop_Elements()
        {
            // Arrange & Act
            stack.Push(1);
            stack.Push(2);

            long poppedElement1 = stack.Pop();
            long poppedElement2 = stack.Pop();

            // Assert
            Assert.AreEqual(2, poppedElement1);
            Assert.AreEqual(1, poppedElement2);
        }

        [TestMethod]
        public void Test_IsEmpty_Initially()
        {
            // Arrange & Act
            bool isEmpty = stack.IsEmpty();

            // Assert
            Assert.IsTrue(isEmpty);
        }

        [TestMethod]
        public void Test_Peek_TopElement()
        {
            // Arrange
            stack.Push(10);

            // Act
            long topElement = stack.Peek();

            // Assert
            Assert.AreEqual(10, topElement);
        }

        [TestMethod]
        public void Test_Size_AfterPushingElements()
        {
            // Arrange & Act
            stack.Push(5);
            stack.Push(6);

            int size = stack.Size();

            // Assert
            Assert.AreEqual(2, size);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Test_Pop_EmptyStack_ThrowsException()
        {
            // Arrange & Act
            stack.Pop();
        }

        [TestMethod]
        public void Test_StringStack()
        {
            // Create a stack to hold strings
            IStack<string> strStack = new GenericStack<string>();

            // Push some elements onto the stack
            strStack.Push("Hello");
            strStack.Push("World");

            string peekedElement = strStack.Peek();
            Assert.AreEqual("World", peekedElement);

            // Pop an element from the stack
            string poppedElement = strStack.Pop();
            Assert.AreEqual("World", poppedElement);

            // Check if the stack is empty
            bool isEmpty = strStack.IsEmpty();
            Assert.IsFalse(isEmpty);

            // Push another element and check the size
            strStack.Push("C#");
            int size = strStack.Size();
            Assert.AreEqual(2, size);

            // Iterate through the stack. This will empty the stack.
            while (strStack.Size() > 0)
            {
                strStack.Pop();
            }

            isEmpty = strStack.IsEmpty();
            Assert.IsTrue(isEmpty);
        }
    }
}
