namespace UniversityHomeworks.ObjectModellingClass.Patterns.Builder
{
    public class ChickenBurger : Burger
    {
        public override float Price()
        {
            return 50.5f;
        }

        public string Name()
        {
            return "Chicken Burger";
        }
    }
}
