namespace UniversityHomeworks.ObjectModellingClass.Patterns.Builder3
{
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
            pizza.SetTopping("ham+pineapple");
        }
    }
}
