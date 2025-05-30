namespace UniversityHomeworks.ObjectModellingClass.Patterns.Builder
{
    /// <summary>
    /// Concrete implementation of a chicken burger.
    /// </summary>
    public class ChickenBurger : Burger
    {
        public override string Name() => "Chicken Burger";
        public override float Price() => 50.5f;
    }
}
