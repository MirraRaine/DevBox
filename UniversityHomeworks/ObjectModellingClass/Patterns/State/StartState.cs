namespace UniversityHomeworks.ObjectModellingClass.Patterns.State
{
    public class StartState : IState
    {
        public void DoAction(Context context)
        {
            //throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
            Console.WriteLine("Player is in start state");
            context.SetState(this);
        }

        public override string ToString()
        {
            return "Start State";
        }
    }
}
