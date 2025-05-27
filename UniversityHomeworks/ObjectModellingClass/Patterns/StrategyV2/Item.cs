namespace UniversityHomeworks.ObjectModellingClass.Patterns.StrategyV2
{
    public class Item
    {
        private string upcCode;
        private int price;

        public Item(string upc, int cost)
        {
            this.upcCode = upc;
            this.price = cost;
        }

        public string GetUpcCode()
        {
            return upcCode;
        }

        public int GetPrice()
        {
            return price;
        }
    }
}
