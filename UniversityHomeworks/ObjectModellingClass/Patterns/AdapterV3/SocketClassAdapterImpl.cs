namespace UniversityHomeworks.ObjectModellingClass.Patterns.AdapterV3
{
    public class SocketClassAdapterImpl : Socket, ISocketAdapter
    {
        public Volt Get120Volt()
        {
            return GetVolt();//from SocketAdapter
        }

        public Volt Get12Volt()
        {
            Volt v = GetVolt();
            return ConvertVolt(v, 10);
        }

        public Volt Get3Volt()
        {
            Volt v = GetVolt();
            return ConvertVolt(v, 40);
        }

        private Volt ConvertVolt(Volt v, int i)
        {
            return new Volt(v.GetVolts() / i);
        }
    }
}
