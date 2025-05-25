using UniversityHomeworks.ObjectModellingClass.Patterns.Builder;

namespace UniversityHomeworksTests.ObjectModellingClass
{
    [TestClass]
    public class BuilderPatternTests
    {
        [TestMethod]
        public void Client_Test()
        {
            MealBuilder mealBuilder = new MealBuilder();

            Meal vegMeal = mealBuilder.prepareVegMeal();

            Console.WriteLine("Veg Meal");
            vegMeal.ShowItems();
            Console.WriteLine("Total Cost: " + vegMeal.GetCost());

            Meal nonVegMeal = mealBuilder.prepareNonVegMeal();
            Console.WriteLine("\n\nNon-Veg Meal");
            nonVegMeal.ShowItems();
            Console.WriteLine("Total Cost: " + nonVegMeal.GetCost());
        }
    }
}
