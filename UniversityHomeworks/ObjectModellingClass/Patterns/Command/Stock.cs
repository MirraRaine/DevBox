namespace UniversityHomeworks.ObjectModellingClass.Patterns.Command
{
    public class Stock
    {
        private readonly string name = "ABC";
        private readonly int quantity = 10;
        private readonly IOutput output;

        public Stock(IOutput output)
        {
            this.output = output;
        }

        public void Buy()
        {
            output.Write($"Stock [ Name: {name}, Quantity: {quantity} ] bought");
        }

        public void Sell()
        {
            output.Write($"Stock [ Name: {name}, Quantity: {quantity} ] sold");
        }
    }
}
