namespace UniversityHomeworks.ObjectModellingClass.Patterns.State
{
    public class StopState : State
    {
        public void DoAction(Context context)
        {
            Console.WriteLine("Player is in stop state");
            context.SetState(this);
        }

        public override string ToString()
        {
            return "Stop State";
        }
    }
}
