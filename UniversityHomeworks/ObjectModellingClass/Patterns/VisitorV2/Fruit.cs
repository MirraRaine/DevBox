namespace UniversityHomeworks.ObjectModellingClass.Patterns.VisitorV2
{
    public class Fruit : ItemElement
    {
        private int pricePerKg;
        private int weight;
        private string name;

        public Fruit(int priceKg, int wt, string nm)
        {
            this.pricePerKg = priceKg;
            this.weight = wt;
            this.name = nm;
        }

        public int GetPricePerKg()
        {
            return pricePerKg;
        }

        public int GetWeight()
        {
            return weight;
        }

        public string GetName()
        {
            return this.name;
        }
        public int Accept(IShoppingCartVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
