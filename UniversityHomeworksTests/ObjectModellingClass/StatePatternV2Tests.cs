using UniversityHomeworks.ObjectModellingClass.Patterns.StateV2;

namespace UniversityHomeworksTests.ObjectModellingClass
{
    [TestClass]
    public class StatePatternV2Tests
    {
        [TestMethod]
        public void Client_Test()
        {
            TVRemoteBasic remote = new TVRemoteBasic();

            remote.SetState("ON");
            remote.DoAction();

            remote.SetState("OFF");
            remote.DoAction();

            // ...

            TVContext context = new TVContext();
            State tvStartState = new TVStartState();
            State tvStopState = new TVStopState();

            context.SetState(tvStartState);
            context.DoAction();

            context.SetState(tvStopState);
            context.DoAction();
        }
    }
}
