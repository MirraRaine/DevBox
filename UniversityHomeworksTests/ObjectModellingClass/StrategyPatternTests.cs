using UniversityHomeworks.ObjectModellingClass.Patterns.Strategy;

namespace UniversityHomeworksTests.ObjectModellingClass
{
    [TestClass]
    public class StrategyPatternTests
    {
        [TestMethod]
        public void Client_Test()
        {
            // TODO code application logic here
            Context context = new Context(new OperationAdd());
            Console.WriteLine("10 + 5 = " + context.ExecuteStrategy(10, 5));


            context = new Context(new OperationSubstract());
            Console.WriteLine("10 - 5 = " + context.ExecuteStrategy(10, 5));

            context = new Context(new OperationMultiply());
            Console.WriteLine("10 * 5 = " + context.ExecuteStrategy(10, 5));
        }
    }
}
