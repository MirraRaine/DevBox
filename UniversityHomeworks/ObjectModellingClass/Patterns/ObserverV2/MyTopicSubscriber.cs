namespace UniversityHomeworks.ObjectModellingClass.Patterns.ObserverV2
{
    public class MyTopicSubscriber : Observer
    {
        private string name;
        private Subject topic;

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

        public void SetSubject(Subject sub)
        {
            this.topic = sub;
        }
    }
}
