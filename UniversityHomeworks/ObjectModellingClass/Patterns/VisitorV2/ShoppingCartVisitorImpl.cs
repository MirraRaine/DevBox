namespace UniversityHomeworks.ObjectModellingClass.Patterns.VisitorV2
{
    public class ShoppingCartVisitorImpl : IShoppingCartVisitor
    {
        public int Visit(Book book)
        {
            int cost = 0;
            //apply 5$ discount if book price is greater than 50
            if (book.GetPrice() > 50)
            {//скидка
                cost = book.GetPrice() - 5;
            }
            else cost = book.GetPrice();
            Console.WriteLine("Book ISBN::" + book.GetIsbnNumber() + " cost =" + cost);
            return cost;
        }

        public int Visit(Fruit fruit)
        {
            int cost = fruit.GetPricePerKg() * fruit.GetWeight();
            Console.WriteLine(fruit.GetName() + " cost = " + cost);
            return cost;
        }
    }
}
