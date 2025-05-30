namespace UniversityHomeworks.ObjectModellingClass.Patterns.AdapterV3
{
    /// <summary>
    /// Adapter using object composition to convert voltage.
    /// </summary>
    public class ObjectSocketAdapter : ISocketAdapter
    {
        private readonly Socket socket = new Socket();

        public Volt Get120Volt() => socket.GetVolt();
        public Volt Get12Volt() => ConvertVolt(socket.GetVolt(), 10);
        public Volt Get3Volt() => ConvertVolt(socket.GetVolt(), 40);

        private Volt ConvertVolt(Volt v, int divisor) => new Volt(v.Volts / divisor);
    }
}
