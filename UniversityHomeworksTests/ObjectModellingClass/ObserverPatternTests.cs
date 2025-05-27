using UniversityHomeworks.ObjectModellingClass.Patterns.Observer;

namespace UniversityHomeworksTests.ObjectModellingClass
{
    [TestClass]
    public class ObserverPatternTests
    {
        [TestMethod]
        public void Client_Test()
        {
            Subject subject = new Subject();

            new HexaObserver(subject);//this.subject = subject; subject.add(thisObserver)
            new OctalObserver(subject);
            new BinaryObserver(subject);

            Console.WriteLine("First state change: 15");
            subject.SetState(15);
            // Console.WriteLine("Second state change: 1");	
            // subject.setState(1);
        }
    }
}
