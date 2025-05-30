namespace UniversityHomeworks.ObjectModellingClass.Patterns.Builder
{
    /// <summary>
    /// Abstract class for Burger items. Provides default packing (Wrapper).
    /// </summary>
    public abstract class Burger : IItem
    {
        public abstract string Name();
        public IPacking Packing() => new Wrapper();
        public abstract float Price();
    }
}
