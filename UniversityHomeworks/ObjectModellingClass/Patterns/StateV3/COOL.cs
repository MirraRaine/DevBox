namespace UniversityHomeworks.ObjectModellingClass.Patterns.StateV3
{
    public class COOL : IState
    {
        public COOL()
        {
            Console.WriteLine("I'm in a cool state");
        }

        public void Say(Princess p, string what)
        {
            Console.WriteLine("i just said to " + p.GetName() + " that " + what);
        }

        public void Meets(StateContext context, Princess p)
        {
            Console.WriteLine("i am meeting princess " + p.GetName());

            context.SetState(new HUNGRY(), p);
            //throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
        }
    }
}
