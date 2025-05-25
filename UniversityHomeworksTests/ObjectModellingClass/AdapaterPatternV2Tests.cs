using UniversityHomeworks.ObjectModellingClass.Patterns.AdapterV2;

namespace UniversityHomeworksTests.ObjectModellingClass
{
    [TestClass]
    public class AdapaterPatternV2Tests
    {
        [TestMethod]
        public void Client_Test()
        {
            Chief ch = new ChiefAdapter();
            object dish = ch.MakeBreakfast();
            Eat(dish);
            dish = ch.MakeLunch();
            Eat(dish);
            dish = ch.MakeDinner();
            Eat(dish);
        }

        public static void Eat(object dish)
        {
            Console.WriteLine("I eat " + dish);
        }
    }
}
