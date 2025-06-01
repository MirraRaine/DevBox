using UniversityHomeworks.ObjectModellingClass.Patterns.ObserverV2;

namespace UniversityHomeworksTests.ObjectModellingClass
{
    [TestClass]
    public class ObserverPatternV2Tests
    {
        [TestMethod]
        public void Client_Test()
        {
            MyTopic topic = new MyTopic();

            //create observers
            IObserver obj1 = new MyTopicSubscriber("Obj1");
            IObserver obj2 = new MyTopicSubscriber("Obj2");
            IObserver obj3 = new MyTopicSubscriber("Obj3");

            //Register observers to the subject
            topic.Register(obj1);
            topic.Register(obj2);
            topic.Register(obj3);

            //attach observer to subject
            obj1.SetSubject(topic);
            obj2.SetSubject(topic);
            obj3.SetSubject(topic);

            //check if any update is available
            obj1.Update();

            //now send message to subject
            topic.PostMessage("You have new mes");
            topic.PostMessage("Second mes");
        }
    }
}
