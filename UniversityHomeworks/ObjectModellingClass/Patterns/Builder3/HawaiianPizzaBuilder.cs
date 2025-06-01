namespace UniversityHomeworks.ObjectModellingClass.Patterns.Builder3
{
    /// <summary>
    /// Concrete builder for creating a Hawaiian pizza.
    /// </summary>
    public class HawaiianPizzaBuilder : PizzaBuilder
    {
        public override void BuildDough()
        {
            pizza.SetDough("cross");
        }

        public override void BuildSauce()
        {
            pizza.SetSauce("mild");
        }

        public override void BuildTopping()
        {
            pizza.SetTopping("ham + pineapple");
        }
    }
}
