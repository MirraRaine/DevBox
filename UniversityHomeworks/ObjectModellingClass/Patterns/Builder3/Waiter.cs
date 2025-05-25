namespace UniversityHomeworks.ObjectModellingClass.Patterns.Builder3
{
    /** "Director" */
    public class Waiter
    {
        private PizzaBuilder pizzaBuilder;

        public void SetPizzaBuilder(PizzaBuilder pb) { pizzaBuilder = pb; }

        public Pizza GetPizza() { return pizzaBuilder.GetPizza(); }

        public void ConstructPizza()
        {
            pizzaBuilder.CreateNewPizzaProduct();
            pizzaBuilder.BuildDough();
            pizzaBuilder.BuildSauce();
            pizzaBuilder.BuildTopping();
        }
    }
}
