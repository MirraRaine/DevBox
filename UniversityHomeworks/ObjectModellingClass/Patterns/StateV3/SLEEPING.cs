namespace UniversityHomeworks.ObjectModellingClass.Patterns.StateV3
{
    public class SLEEPING : IState
    {
        public SLEEPING()
        {
            Console.WriteLine("I'm in a sleepy state");
        }

        public void Meets(StateContext context, Princess p)
        {
            Console.WriteLine("i am meeting princess " + p.GetName());
            context.SetState(new COOL(), p);
            // throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
        }
    }

}
