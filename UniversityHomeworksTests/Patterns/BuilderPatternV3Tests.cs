using UniversityHomeworks.ObjectModellingClass.Patterns.Builder3;

namespace UniversityHomeworksTests.Patterns
{
    [TestClass]
    public class BuilderPatternV3Tests
    {
        [TestMethod]
        public void HawaiianPizzaBuilder_ShouldBuildCorrectPizza()
        {
            // Arrange
            var waiter = new Waiter();
            var hawaiianBuilder = new HawaiianPizzaBuilder();

            // Act
            waiter.SetPizzaBuilder(hawaiianBuilder);
            waiter.ConstructPizza();
            var pizza = waiter.GetPizza();
            var pizzaDescription = pizza.ToString();

            // Assert
            Assert.AreEqual("Pizza with cross dough, mild sauce, and ham + pineapple topping(s).", pizzaDescription);
        }

        [TestMethod]
        public void SpicyPizzaBuilder_ShouldBuildCorrectPizza()
        {
            // Arrange
            var waiter = new Waiter();
            var spicyBuilder = new SpicyPizzaBuilder();

            // Act
            waiter.SetPizzaBuilder(spicyBuilder);
            waiter.ConstructPizza();
            var pizza = waiter.GetPizza();
            var pizzaDescription = pizza.ToString();

            // Assert
            Assert.AreEqual("Pizza with pan baked dough, hot sauce, and pepperoni + salami topping(s).", pizzaDescription);
        }
    }
}
