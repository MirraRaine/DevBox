namespace UniversityHomeworks.ObjectModellingClass.Patterns.AdapterV3
{
    public class SocketObjectAdapterImpl : ISocketAdapter
    {
        //Using Composition for adapter pattern
        private Socket sock = new Socket();

        public Volt Get120Volt()
        {
            return sock.GetVolt();
        }

        public Volt Get12Volt()
        {
            Volt v = sock.GetVolt();
            return ConvertVolt(v, 10);
        }

        public Volt Get3Volt()
        {
            Volt v = sock.GetVolt();
            return ConvertVolt(v, 40);
        }

        private Volt ConvertVolt(Volt v, int i)
        {
            return new Volt(v.GetVolts() / i);
        }
    }
}
