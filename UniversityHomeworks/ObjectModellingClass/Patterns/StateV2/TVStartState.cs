namespace UniversityHomeworks.ObjectModellingClass.Patterns.StateV2
{
    public class TVStartState : State
    {
        public void DoAction()
        {
            Console.WriteLine("TV is turned ON");
        }
    }
}
