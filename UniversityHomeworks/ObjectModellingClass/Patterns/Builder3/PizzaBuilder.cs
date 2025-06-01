namespace UniversityHomeworks.ObjectModellingClass.Patterns.Builder3
{
    /// <summary>
    /// Abstract builder class that defines the steps to build a pizza.
    /// </summary>
    public abstract class PizzaBuilder
    {
        protected Pizza pizza;

        /// <summary>
        /// Gets the built pizza.
        /// </summary>
        public Pizza GetPizza() => pizza;

        /// <summary>
        /// Creates a new instance of a Pizza.
        /// </summary>
        public void CreateNewPizzaProduct() => pizza = new Pizza();

        /// <summary>
        /// Builds the dough part of the pizza.
        /// </summary>
        public abstract void BuildDough();

        /// <summary>
        /// Builds the sauce part of the pizza.
        /// </summary>
        public abstract void BuildSauce();

        /// <summary>
        /// Builds the topping part of the pizza.
        /// </summary>
        public abstract void BuildTopping();
    }
}
