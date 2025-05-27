namespace UniversityHomeworks.ObjectModellingClass.Patterns.Observer
{
    public class BinaryObserver : Observer
    {
        public BinaryObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.Add(this);
        }

        public override void Update()
        {
            Console.WriteLine("Binary String: " + Convert.ToString(subject.GetState(), 2));
        }
    }
}
