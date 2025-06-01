using UniversityHomeworks.ObjectModellingClass.Patterns.Command;

namespace UniversityHomeworksTests.ObjectModellingClass
{
    [TestClass]
    public class CommandPatternTests
    {
        private class MockOrder : IOrder
        {
            public bool WasExecuted { get; private set; } = false;

            public void Execute()
            {
                WasExecuted = true;
            }
        }

        [TestMethod]
        public void TakeOrder_ShouldAddOrderToQueue()
        {
            // Arrange
            var broker = new Broker();
            var mockOrder = new MockOrder();

            // Act
            broker.TakeOrder(mockOrder);

            // Assert
            Assert.AreEqual(1, broker.Orders.Count);
            Assert.IsTrue(broker.Orders.Contains(mockOrder));
        }

        [TestMethod]
        public void PlaceOrders_ShouldExecuteAllOrders_AndClearQueue()
        {
            // Arrange
            var broker = new Broker();
            var mockOrder1 = new MockOrder();
            var mockOrder2 = new MockOrder();
            broker.TakeOrder(mockOrder1);
            broker.TakeOrder(mockOrder2);

            // Act
            broker.PlaceOrders();

            // Assert
            Assert.IsTrue(mockOrder1.WasExecuted);
            Assert.IsTrue(mockOrder2.WasExecuted);
            Assert.AreEqual(0, broker.Orders.Count);
        }

        [TestMethod]
        public void Orders_ShouldBeReadOnly()
        {
            // Arrange
            var broker = new Broker();

            // Act
            var orders = broker.Orders;

            // Assert
            Assert.IsInstanceOfType(orders, typeof(IReadOnlyCollection<IOrder>));
        }
    }
}

