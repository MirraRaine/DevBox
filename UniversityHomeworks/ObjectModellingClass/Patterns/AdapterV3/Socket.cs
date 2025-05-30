namespace UniversityHomeworks.ObjectModellingClass.Patterns.AdapterV3
{
    /// <summary>
    /// Legacy class that provides only 120V power.
    /// </summary>
    public class Socket
    {
        /// <summary>
        /// Returns the default voltage (120V).
        /// </summary>
        public Volt GetVolt()
        {
            return new Volt(120);
        }
    }

}
