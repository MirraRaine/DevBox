
namespace UniversityHomeworks.ObjectModellingClass.Patterns.Builder
{
    public class Coke : ColdDrink
    {
        public override float Price()
        {
            return 30.0f;
        }

        public string Name()
        {
            return "Coke";
        }
    }
}
