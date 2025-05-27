namespace UniversityHomeworks.ObjectModellingClass.Patterns.FactoryV2
{
    public class ComputerFactory
    {
        public static Computer GetComputer(string type, String ram, String hdd, String cpu)
        {

            if ("PC".Equals(type, StringComparison.OrdinalIgnoreCase)) { return new PC(ram, hdd, cpu); }
            else if ("Server".Equals(type, StringComparison.OrdinalIgnoreCase)) return new Server(ram, hdd, cpu);

            return null;
        }
    }
}
