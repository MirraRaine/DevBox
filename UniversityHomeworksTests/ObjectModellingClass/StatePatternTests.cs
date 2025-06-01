using UniversityHomeworks.ObjectModellingClass.Patterns.State;

namespace UniversityHomeworksTests.ObjectModellingClass
{
    [TestClass]
    public class StatePatternTests
    {
        [TestMethod]
        public void Client_Test()
        {
            Context context = new Context();

            IState startState = new StartState();
            startState.DoAction(context);

            Console.WriteLine(context.GetState().ToString());

            IState stopState = new StopState();
            stopState.DoAction(context);

            Console.WriteLine(context.GetState().ToString());
        }
    }
}
