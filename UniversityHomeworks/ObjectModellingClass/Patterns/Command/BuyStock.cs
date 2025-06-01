namespace UniversityHomeworks.ObjectModellingClass.Patterns.Command
{
    /// <summary>
    /// Concrete command to buy stock.
    /// </summary>
    public class BuyStock : IOrder
    {
        private readonly Stock stock;

        /// <summary>
        /// Initializes a new instance of the <see cref="BuyStock"/> class.
        /// </summary>
        /// <param name="stock">The stock receiver object.</param>
        public BuyStock(Stock stock)
        {
            this.stock = stock;
        }

        /// <inheritdoc />
        public void Execute()
        {
            stock.Buy();
        }
    }
}
