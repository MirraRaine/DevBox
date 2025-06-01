namespace UniversityHomeworks.ObjectModellingClass.Patterns.StateV3
{
    public interface IState
    {
        public void Meets(StateContext context, Princess p);
    }
}
