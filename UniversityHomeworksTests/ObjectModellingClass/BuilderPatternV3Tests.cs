using UniversityHomeworks.ObjectModellingClass.Patterns.Builder3;

namespace UniversityHomeworksTests.ObjectModellingClass
{
    [TestClass]
    public class BuilderPatternV3Tests
    {
        [TestMethod]
        public void Client_Test()
        {
            Waiter waiter = new Waiter();

            PizzaBuilder hawaiianPizzaBuilder = new HawaiianPizzaBuilder();
            waiter.SetPizzaBuilder(hawaiianPizzaBuilder);

            waiter.ConstructPizza();

            Pizza pizza = waiter.GetPizza();
        }
    }
}
