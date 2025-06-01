namespace UniversityHomeworks.ObjectModellingClass.Patterns.State
{
    public class Context
    {
        private IState state;

        public Context()
        {
            state = null;
        }

        public void SetState(IState state)
        {
            this.state = state;
        }

        public IState GetState()
        {
            return state;
        }
    }
}
