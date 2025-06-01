namespace UniversityHomeworks.ObjectModellingClass.Patterns.StateV2
{
    public class TVContext : IState
    {
        private IState tvState;

        public void SetState(IState state)
        {
            this.tvState = state;
        }

        public IState GetState()
        {
            return this.tvState;
        }

        public void DoAction()
        {
            this.tvState.DoAction();
        }
    }
}
