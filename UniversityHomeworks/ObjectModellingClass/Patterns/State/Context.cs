namespace UniversityHomeworks.ObjectModellingClass.Patterns.State
{
    public class Context
    {
        private State state;

        public Context()
        {
            state = null;
        }

        public void SetState(State state)
        {
            this.state = state;
        }

        public State GetState()
        {
            return state;
        }
    }
}
