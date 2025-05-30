namespace UniversityHomeworks.ObjectModellingClass.Patterns.Builder
{
    /// <summary>
    /// Abstract class for ColdDrink items. Provides default packing (Bottle).
    /// </summary>
    public abstract class ColdDrink : IItem
    {
        public abstract string Name();
        public IPacking Packing() => new Bottle();
        public abstract float Price();
    }
}
