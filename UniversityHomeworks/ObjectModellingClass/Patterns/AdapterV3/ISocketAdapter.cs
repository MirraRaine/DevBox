
namespace UniversityHomeworks.ObjectModellingClass.Patterns.AdapterV3
{
    public interface ISocketAdapter
    {
        public Volt Get120Volt();

        public Volt Get12Volt();

        public Volt Get3Volt();
    }
}
