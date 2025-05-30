namespace UniversityHomeworks.ObjectModellingClass.Patterns.AdapterV3
{
    /// <summary>
    /// Adapter using class inheritance to convert voltage.
    /// </summary>
    public class ClassSocketAdapter : Socket, ISocketAdapter
    {
        public Volt Get120Volt() => GetVolt();
        public Volt Get12Volt() => ConvertVolt(GetVolt(), 10);
        public Volt Get3Volt() => ConvertVolt(GetVolt(), 40);

        private Volt ConvertVolt(Volt v, int divisor) => new Volt(v.Volts / divisor);
    }
}
