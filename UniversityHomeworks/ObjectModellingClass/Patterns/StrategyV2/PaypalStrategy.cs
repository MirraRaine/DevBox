namespace UniversityHomeworks.ObjectModellingClass.Patterns.StrategyV2
{
    public class PaypalStrategy : IPaymentStrategy
    {
        private string emailId;
        private string password;

        public PaypalStrategy(string email, string pwd)
        {
            this.emailId = email;
            this.password = pwd;
        }

        public void Pay(int amount)
        {
            Console.WriteLine(amount + " paid using Paypal.");
        }
    }
}
