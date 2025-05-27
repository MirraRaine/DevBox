namespace UniversityHomeworks.ObjectModellingClass.Patterns.StateV3
{
    public interface State
    {
        public void Meets(StateContext context, Princess p);
    }
}
