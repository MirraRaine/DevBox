namespace UniversityHomeworks.ObjectModellingClass.Patterns.AdapterV2
{
    /// <summary>
    /// Adaptee class that performs plumbing work.
    /// This class has no concept of cooking but provides plumbing parts.
    /// </summary>
    public class Plumber
    {
        public object GetScrewNut() => "ScrewNut";
        public object GetPipe() => "Pipe";
        public object GetGasket() => "Gasket";
    }
}
