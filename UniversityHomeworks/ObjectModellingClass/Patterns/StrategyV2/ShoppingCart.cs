namespace UniversityHomeworks.ObjectModellingClass.Patterns.StrategyV2
{
    public class ShoppingCart
    {

        //List of items
        List<Item> items;

        public ShoppingCart()
        {
            this.items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            this.items.Add(item);
            // Console.WriteLine(item.getPrice());
        }

        public void RemoveItem(Item item)
        {
            this.items.Remove(item);
        }

        public int CalculateTotal()
        {
            int sum = 0;
            foreach (Item item in items)
            {
                sum += item.GetPrice();
                Console.WriteLine("sum on your cart: " + sum);
            }
            return sum;
        }

        public void Pay(IPaymentStrategy paymentMethod)
        {
            int amount = CalculateTotal();//складывает всё, что есть на карте
            paymentMethod.Pay(amount);
        }
    }
}
