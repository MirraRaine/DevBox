namespace UniversityHomeworks.ObjectModellingClass.Patterns.Builder3
{
    /// <summary>
    /// The Director class that defines the order of building steps.
    /// </summary>
    public class Waiter
    {
        private PizzaBuilder pizzaBuilder;
        
        /// <summary>
        /// Sets the builder instance used by the director.
        /// </summary>
        public void SetPizzaBuilder(PizzaBuilder pb) => this.pizzaBuilder = pb;

        /// <summary>
        /// Gets the pizza that has been constructed.
        /// </summary>
        public Pizza GetPizza() => this.pizzaBuilder.GetPizza();

        /// <summary>
        /// Orchestrates the building of the pizza in the defined sequence.
        /// </summary>
        public void ConstructPizza()
        {
            pizzaBuilder.CreateNewPizzaProduct();
            pizzaBuilder.BuildDough();
            pizzaBuilder.BuildSauce();
            pizzaBuilder.BuildTopping();
        }
    }
}