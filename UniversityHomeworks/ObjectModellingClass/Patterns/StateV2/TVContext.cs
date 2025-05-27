namespace UniversityHomeworks.ObjectModellingClass.Patterns.StateV2
{
    public class TVContext : State
    {
        private State tvState;

        public void SetState(State state)
        {
            this.tvState = state;
        }

        public State GetState()
        {
            return this.tvState;
        }

        public void DoAction()
        {
            this.tvState.DoAction();
        }
    }
}
