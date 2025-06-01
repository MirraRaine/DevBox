using UniversityHomeworks.ObjectModellingClass.Patterns.StateV3;

namespace UniversityHomeworksTests.ObjectModellingClass
{
    [TestClass]
    public class StatePatternV3Tests
    {
        [TestMethod]
        public void Client_Test()
        {
            StateContext c = new StateContext();
            Princess p = new Princess("Ariel");
            IState sleepy = new SLEEPING();
            sleepy.Meets(c, p);
            Console.WriteLine(c.GetState());

            IState cool = new COOL();
            cool.Meets(c, p);
            Console.WriteLine(c.GetState());
        }
    }
}
