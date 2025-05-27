using UniversityHomeworks.ObjectModellingClass.Patterns.VisitorV2;

namespace UniversityHomeworksTests.ObjectModellingClass
{
    [TestClass]
    public class VisitorPatternV2Tests
    {
        [TestMethod]
        public void Client_Test()
        {
            // ShoppingCartClient
            ItemElement[] items = new ItemElement[]{new Book(20, "1234"),new Book(100, "5678"),
                new Fruit(10, 2, "Banana"), new Fruit(5, 5, "Apple")};

            ShoppingCartVisitorImpl visitor = new ShoppingCartVisitorImpl();

            int sum = 0;
            foreach (ItemElement item in items)
            {
                //sum = sum + item.accept(new ShoppingCartVisitorImpl());
                sum = sum + item.Accept(visitor);
            }

            Console.WriteLine("Total Cost = " + sum);
        }
    }
}
