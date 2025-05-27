namespace UniversityHomeworks.ObjectModellingClass.Patterns.StateV3
{
    public class StateContext
    {
        private State state;

        public StateContext()
        {
            state = null;
        }

        public void SetState(State state, Princess p)
        {
            this.state = state;
        }

        public State GetState()
        {
            return state;
        }
    }
}
