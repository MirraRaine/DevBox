namespace UniversityHomeworks.ObjectModellingClass.Patterns.AdapterV3
{
    public class Socket
    {
        public Volt GetVolt()
        {
            return new Volt(120);
        }
    }
}
