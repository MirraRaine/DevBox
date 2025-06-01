namespace UniversityHomeworks.ObjectModellingClass.Patterns.Command
{
    /// <summary>
    /// Concrete command to sell stock.
    /// </summary>
    public class SellStock : IOrder
    {
        private readonly Stock stock;

        /// <summary>
        /// Initializes a new instance of the <see cref="SellStock"/> class.
        /// </summary>
        /// <param name="stock">The stock receiver object.</param>
        public SellStock(Stock stock)
        {
            this.stock = stock;
        }

        /// <inheritdoc />
        public void Execute()
        {
            stock.Sell();
        }
    }
}
