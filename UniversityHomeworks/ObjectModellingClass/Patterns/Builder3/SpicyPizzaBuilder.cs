namespace UniversityHomeworks.ObjectModellingClass.Patterns.Builder3
{
    /// <summary>
    /// Concrete builder for creating a spicy pizza.
    /// </summary>
    public class SpicyPizzaBuilder : PizzaBuilder
    {
        public override void BuildDough()
        {
            pizza.SetDough("pan baked");
        }

        public override void BuildSauce()
        {
            pizza.SetSauce("hot");
        }

        public override void BuildTopping()
        {
            pizza.SetTopping("pepperoni + salami");
        }
    }
}
