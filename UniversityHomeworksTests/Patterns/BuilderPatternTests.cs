using UniversityHomeworks.ObjectModellingClass.Patterns.Builder;

namespace UniversityHomeworksTests.Patterns
{
    [TestClass]
    public class BuilderPatternTests
    {
        [TestMethod]
        public void PrepareVegMeal_ShouldContainVegBurgerAndCoke()
        {
            // Arrange
            var builder = new MealBuilder();

            // Act
            Meal meal = builder.PrepareVegMeal();

            // Assert
            Assert.AreEqual(2, meal.GetItems().Count);
            Assert.IsTrue(meal.GetItems().Exists(item => item.Name() == "Veg Burger"));
            Assert.IsTrue(meal.GetItems().Exists(item => item.Name() == "Coke"));
            Assert.AreEqual(55.0f, meal.GetCost());
        }

        [TestMethod]
        public void PrepareNonVegMeal_ShouldContainChickenBurgerAndPepsi()
        {
            // Arrange
            var builder = new MealBuilder();

            // Act
            Meal meal = builder.PrepareNonVegMeal();

            // Assert
            Assert.AreEqual(2, meal.GetItems().Count);
            Assert.IsTrue(meal.GetItems().Exists(item => item.Name() == "Chicken Burger"));
            Assert.IsTrue(meal.GetItems().Exists(item => item.Name() == "Pepsi"));
            Assert.AreEqual(85.5f, meal.GetCost());
        }

        [TestMethod]
        public void GetCost_ShouldReturnCorrectTotal()
        {
            // Arrange
            var meal = new Meal();
            meal.AddItem(new VegBurger());     // 25.0
            meal.AddItem(new Coke());          // 30.0
            meal.AddItem(new ChickenBurger()); // 50.5

            // Act
            float cost = meal.GetCost();

            // Assert
            Assert.AreEqual(105.5f, cost);
        }

        [TestMethod]
        public void ShowItems_ShouldPrintItemDetails()
        {
            // Arrange
            var meal = new Meal();
            meal.AddItem(new VegBurger());
            meal.AddItem(new Pepsi());

            // Act & Assert
            meal.ShowItems(); // Only for manual visual verification
        }
    }
}
