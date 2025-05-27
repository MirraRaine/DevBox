namespace UniversityHomeworks.ObjectModellingClass.Patterns.StateV2
{
    public class TVStopState : State
    {
        public void DoAction()
        {
            Console.WriteLine("TV is turned OFF");
        }
    }
}
