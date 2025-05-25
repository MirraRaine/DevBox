namespace UniversityHomeworks.ObjectModellingClass.Patterns.AdapterV2
{
    public class ChiefAdapter : Plumber, Chief
    {
        public object MakeBreakfast()
        {
            return GetGasket();
        }
        public object MakeLunch()
        {
            return GetPipe();
        }
        public object MakeDinner()
        {
            return GetScrewNut();
        }
    }
}
