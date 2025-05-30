namespace UniversityHomeworks.ObjectModellingClass.Patterns.AdapterV3
{
    /// <summary>
    /// Represents a voltage value.
    /// </summary>
    public class Volt
    {
        public int Volts { get; set; }

        public Volt(int volts)
        {
            Volts = volts;
        }
    }
}
