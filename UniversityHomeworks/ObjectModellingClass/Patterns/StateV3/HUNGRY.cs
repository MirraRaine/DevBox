namespace UniversityHomeworks.ObjectModellingClass.Patterns.StateV3
{
    public class HUNGRY : State
    {
        public HUNGRY()
        {
            Console.WriteLine("I'm in a hungry state");
        }

        public void eat(Princess p)
        {
            Console.WriteLine("i just ate " + p.GetName());
        }

        public void Meets(StateContext context, Princess p)
        {
            Console.WriteLine("i am meeting princess " + p.GetName());
            context.SetState(new SLEEPING(), p);
        }
    }
}
