using UniversityHomeworks.ObjectModellingClass.Patterns.StrategyV2;

namespace UniversityHomeworksTests.ObjectModellingClass
{
    [TestClass]
    public class StrategyPatternV2Tests
    {
        [TestMethod]
        public void Client_Test()
        {
            ShoppingCart cart = new ShoppingCart();

            Item item1 = new Item("1234", 10);
            Item item2 = new Item("5678", 40);

            cart.AddItem(item1);
            cart.AddItem(item2);

            //pay by paypal
            cart.Pay(new PaypalStrategy("myemail@example.com", "mypwd")); //pay складывает всё, что есть на картеЖ 10+40

            //pay by credit card
            cart.Pay(new CreditCardStrategy("Pankaj Kumar", "1234567890123456", "786", "12/15"));
        }
    }
}
