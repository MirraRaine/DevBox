using UniversityHomeworks.ObjectModellingClass.Patterns.Command;

namespace UniversityHomeworksTests.ObjectModellingClass
{
    public class CommandPatternTests
    {
        [TestMethod]
        public void Client_Test()
        {
            Stock abcStock = new Stock();

            BuyStock buyStockOrder = new BuyStock(abcStock);
            SellStock sellStockOrder = new SellStock(abcStock);

            Broker broker = new Broker();
            broker.TakeOrder(buyStockOrder);
            broker.TakeOrder(sellStockOrder);

            broker.PlaceOrders();
        }
    }
}
