namespace UniversityHomeworks.ObjectModellingClass.Patterns.AdapterV2
{
    /// <summary>
    /// Object Adapter implementation using composition to adapt Plumber to Chief.
    /// Holds a reference to a Plumber object.
    /// Meaning: “I have a plumber to do the work (wrap).”
    /// </summary>
    public class ChefAdapterByComposition : IChief
    {
        private readonly Plumber plumber = new Plumber();

        public object MakeBreakfast() => plumber.GetGasket();
        public object MakeLunch() => plumber.GetPipe();
        public object MakeDinner() => plumber.GetScrewNut();
    }
}
