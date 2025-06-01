namespace UniversityHomeworks.ObjectModellingClass.Patterns.VisitorV2
{
    public class Book : ItemElement
    {
        private int price;
        private string isbnNumber;

        public Book(int cost, string isbn)
        {
            this.price = cost;
            this.isbnNumber = isbn;
        }

        public int GetPrice()
        {
            return price;
        }

        public string GetIsbnNumber()
        {
            return isbnNumber;
        }

        public int Accept(IShoppingCartVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
