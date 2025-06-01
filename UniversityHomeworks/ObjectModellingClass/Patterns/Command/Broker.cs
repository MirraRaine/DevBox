namespace UniversityHomeworks.ObjectModellingClass.Patterns.Command
{
    /// <summary>
    /// The invoker class that queues and executes orders.
    /// </summary>
    public class Broker
    {
        private readonly List<IOrder> orderList = new();

        /// <summary>
        /// Adds an order to the queue.
        /// </summary>
        /// <param name="order">The command to queue.</param>
        public void TakeOrder(IOrder order)
        {
            orderList.Add(order);
        }

        /// <summary>
        /// Executes all queued orders and clears the queue.
        /// </summary>
        public void PlaceOrders()
        {
            foreach (var order in orderList)
            {
                order.Execute();
            }
            orderList.Clear();
        }

        /// <summary>
        /// Exposes a read-only view of the queued orders (for testing/monitoring).
        /// </summary>
        public IReadOnlyCollection<IOrder> Orders => orderList.AsReadOnly();
    }
}
