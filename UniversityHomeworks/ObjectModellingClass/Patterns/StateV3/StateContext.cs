namespace UniversityHomeworks.ObjectModellingClass.Patterns.StateV3
{
    public class StateContext
    {
        private IState state;

        public StateContext()
        {
            state = null;
        }

        public void SetState(IState state, Princess p)
        {
            this.state = state;
        }

        public IState GetState()
        {
            return state;
        }
    }
}
