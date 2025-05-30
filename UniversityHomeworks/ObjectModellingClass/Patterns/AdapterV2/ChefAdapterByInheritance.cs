namespace UniversityHomeworks.ObjectModellingClass.Patterns.AdapterV2
{
    /// <summary>
    /// Class Adapter implementation using inheritance to adapt Plumber to Chief.
    /// Inherits from Plumber and implements Chief.
    /// Meaning: “I am also a plumber (inherit).”
    /// </summary>
    public class ChefAdapterByInheritance : Plumber, IChief
    {
        public object MakeBreakfast() => GetGasket();
        public object MakeLunch() => GetPipe();
        public object MakeDinner() => GetScrewNut();
    }
}
