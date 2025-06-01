namespace UniversityHomeworks.ObjectModellingClass.Patterns.ObserverV2
{
    public class MyTopicSubscriber : IObserver
    {
        private string name;
        private ISubject topic;

        public MyTopicSubscriber(string nm)
        {
            this.name = nm;
        }

        public void Update()
        {
            string msg = (string)topic.GetUpdate(this);
            if (msg == null)
            {
                Console.WriteLine(name + ":: No new message");
            }
            else
                Console.WriteLine(name + ":: Consuming message::" + msg);
        }

        public void SetSubject(ISubject sub)
        {
            this.topic = sub;
        }
    }
}
