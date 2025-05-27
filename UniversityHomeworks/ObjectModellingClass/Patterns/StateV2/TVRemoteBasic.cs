namespace UniversityHomeworks.ObjectModellingClass.Patterns.StateV2
{
    public class TVRemoteBasic
    {
        private string state = "";

        public void SetState(string state)
        {
            this.state = state;
        }

        public void DoAction()
        {
            if (state.Equals("ON", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("TV is turned ON");
            }
            else if (state.Equals("OFF", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("TV is turned OFF");
            }
        }
    }
}