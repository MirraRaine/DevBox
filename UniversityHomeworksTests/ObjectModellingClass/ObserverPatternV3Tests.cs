using UniversityHomeworks.ObjectModellingClass.Patterns.ObserverV3;

namespace UniversityHomeworksTests.ObjectModellingClass
{
    [TestClass]
    public class ObserverPatternV3Tests
    {
        [TestMethod]
        public void Client_Test()
        {
            Context ctx = new Context();

            new ObserverDoWork(ctx);
            new ObserverIsReady(ctx);
            new ObserverIsSleeping(ctx);
            ctx.SetState("is Ready");

            ctx.SetState("is Sleeping");

            // blabla: not sure why I need it

            //Machine m = new Machine();
            //Worker w;
            //for (int i = 0; i < 10; ++i)
            //{
            //    w = new Worker(m);
            //    w.doWork();
            //}
        }
    }
}
