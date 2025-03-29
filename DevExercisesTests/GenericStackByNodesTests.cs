using DevExercises;

/// <summary>
/// Test class to validate functionality of the <see cref="GenericStackByNodes"/> class.
/// </summary>
[TestClass]
public class GenericStackByNodesTests
{
    [TestMethod]
    public void Test_IsEmpty_WhenStackIsEmpty_ReturnsTrue()
    {
        // Arrange
        var stack = new GenericStackByNodes<int>();

        // Act
        bool isEmpty = stack.IsEmpty();

        // Assert
        Assert.IsTrue(isEmpty);
    }

    [TestMethod]
    public void Test_Size_WhenStackIsCreated_SizeIsZero()
    {
        // Arrange
        var stack = new GenericStackByNodes<string>();

        // Act
        int size = stack.Size();

        // Assert
        Assert.AreEqual(0, size);
    }

    [TestMethod]
    public void Test_PushAndPop_SingleElement_PushesAndPopsCorrectly()
    {
        // Arrange
        var stack = new GenericStackByNodes<int>();
        int valueToPush = 42;

        // Act
        stack.Push(valueToPush);
        bool isEmptyAfterPush = stack.IsEmpty();
        int sizeAfterPush = stack.Size();

        int poppedValue = stack.Pop();
        bool isEmptyAfterPop = stack.IsEmpty();
        int sizeAfterPop = stack.Size();

        // Assert
        Assert.IsFalse(isEmptyAfterPush);
        Assert.AreEqual(1, sizeAfterPush);

        Assert.IsTrue(isEmptyAfterPop);
        Assert.AreEqual(0, sizeAfterPop);
        Assert.AreEqual(valueToPush, poppedValue);
    }

    [TestMethod]
    public void Test_Peek_WhenStackHasElements_ReturnsTopElement()
    {
        // Arrange
        var stack = new GenericStackByNodes<string>();
        string topValue = "top";

        // Act
        stack.Push("bottom");
        stack.Push(topValue);

        string peekedValue = stack.Peek();
        bool isEmptyAfterPeek = stack.IsEmpty();

        // Assert
        Assert.AreEqual(topValue, peekedValue);
        Assert.IsFalse(isEmptyAfterPeek);
    }

    [TestMethod]
    public void Test_Pop_WhenStackHasMultipleElements_PopsInLifoOrder()
    {
        // Arrange
        var stack = new GenericStackByNodes<int>();
        int[] valuesToPush = { 1, 2, 3 };

        foreach (int value in valuesToPush)
        {
            stack.Push(value);
        }

        // Act & Assert
        for (int i = valuesToPush.Length - 1; i >= 0; i--)
        {
            int poppedValue = stack.Pop();
            Assert.AreEqual(valuesToPush[i], poppedValue);
        }
    }

    [TestMethod]
    public void Test_Peek_WhenStackIsEmpty_ThrowsInvalidOperationException()
    {
        // Arrange
        var stack = new GenericStackByNodes<int>();

        // Act & Assert
        try
        {
            stack.Peek();
            Assert.Fail("Expected InvalidOperationException was not thrown.");
        }
        catch (InvalidOperationException ex)
        {
            Assert.AreEqual("Empty stack.", ex.Message);
        }
    }

    [TestMethod]
    public void Pop_WhenStackIsEmpty_ThrowsInvalidOperationException()
    {
        // Arrange
        var stack = new GenericStackByNodes<int>();

        // Act & Assert
        try
        {
            stack.Pop();
            Assert.Fail("Expected InvalidOperationException was not thrown.");
        }
        catch (InvalidOperationException ex)
        {
            Assert.AreEqual("Empty stack.", ex.Message);
        }
    }
}