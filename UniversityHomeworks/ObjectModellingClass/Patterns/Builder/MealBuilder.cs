namespace UniversityHomeworks.ObjectModellingClass.Patterns.Builder
{
    /// <summary>
    /// Builder class that constructs specific meal combinations.
    /// </summary>
    public class MealBuilder
    {
        /// <summary>
        /// Builds a vegetarian meal (VegBurger + Coke).
        /// </summary>
        public Meal PrepareVegMeal()
        {
            var meal = new Meal();
            meal.AddItem(new VegBurger());
            meal.AddItem(new Coke());
            return meal;
        }

        /// <summary>
        /// Builds a non-vegetarian meal (ChickenBurger + Pepsi).
        /// </summary>
        public Meal PrepareNonVegMeal()
        {
            var meal = new Meal();
            meal.AddItem(new ChickenBurger());
            meal.AddItem(new Pepsi());
            return meal;
        }
    }
}
