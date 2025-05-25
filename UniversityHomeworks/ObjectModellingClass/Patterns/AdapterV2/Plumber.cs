namespace UniversityHomeworks.ObjectModellingClass.Patterns.AdapterV2
{
    /// Adaptee
//водопроводчик
    public class Plumber
    {
        public object GetScrewNut() { return "ScrewNut"; }
        public object GetPipe()
        { return "Pipe"; }
        public object GetGasket()
        { return "Gasket"; }
    }
}
