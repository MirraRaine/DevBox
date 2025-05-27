namespace UniversityHomeworks.ObjectModellingClass.Patterns.StrategyV2
{
    public class CreditCardStrategy : PaymentStrategy
    {
        private string name;
        private string cardNumber;
        private string cvv;
        private string dateOfExpiry;

        public CreditCardStrategy(string nm, string ccNum, string cvv, string expiryDate)
        {
            this.name = nm;
            this.cardNumber = ccNum;
            this.cvv = cvv;
            this.dateOfExpiry = expiryDate;
        }

        public void Pay(int amount)
        {
            Console.WriteLine(amount + " paid with credit/debit card");
        }
    }
}
