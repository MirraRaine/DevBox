
namespace UniversityHomeworks.ObjectModellingClass.Patterns.Builder
{
    /// <summary>
    /// Concrete implementation of Coke drink.
    /// </summary>
    public class Coke : ColdDrink
    {
        public override string Name() => "Coke";
        public override float Price() => 30.0f;
    }
}
