namespace UniversityHomeworks.ObjectModellingClass.Patterns.Observer
{
    public class OctalObserver : Observer
    {
        public OctalObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.Add(this);
        }

        public override void Update()
        {
            Console.WriteLine("Octal String: " + Convert.ToString(subject.GetState(), 8));
        }
    }
}
