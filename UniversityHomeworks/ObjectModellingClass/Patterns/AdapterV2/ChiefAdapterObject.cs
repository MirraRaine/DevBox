namespace UniversityHomeworks.ObjectModellingClass.Patterns.AdapterV2
{
    public class ChiefAdapterObject : Chief
    {
        Plumber plumber = new Plumber();

        public object MakeBreakfast()
        {
            return plumber.GetGasket();
        }

        public object MakeLunch()
        {
            return plumber.GetPipe();
        }

        public object MakeDinner()
        {
            return plumber.GetScrewNut();
        }
    }
}
