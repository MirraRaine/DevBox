namespace UniversityHomeworks.ObjectModellingClass.Patterns.Builder
{
    /// <summary>
    /// Item interface represents a food or drink item in the meal.
    /// </summary>
    public interface IItem
    {
        string Name();
        IPacking Packing();
        float Price();
    }
}
