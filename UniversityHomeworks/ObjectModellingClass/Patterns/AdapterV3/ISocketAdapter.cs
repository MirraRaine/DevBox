
namespace UniversityHomeworks.ObjectModellingClass.Patterns.AdapterV3
{
    /// <summary>
    /// Target interface expected by client code to get various voltage levels.
    /// </summary>
    public interface ISocketAdapter
    {
        Volt Get120Volt();
        Volt Get12Volt();
        Volt Get3Volt();
    }
}
