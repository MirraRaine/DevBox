namespace UniversityHomeworks.ObjectModellingClass.Patterns.Observer
{
    public class HexaObserver : Observer
    {
        public HexaObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.Add(this);
        }

        public override void Update()
        {
            Console.WriteLine("Hex String: " + Convert.ToString(subject.GetState(), 16).ToUpper());
        }
    }
}
