namespace UniversityHomeworks.ObjectModellingClass.Patterns.Builder
{
    public class VegBurger : Burger
    {
        public string Name()
        {
            return "Veg Burger";
        }

        public override float Price()
        {
            return 25.0f;
        }
    }
}
