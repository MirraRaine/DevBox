namespace UniversityHomeworks.ObjectModellingClass.Patterns.Builder
{
    public abstract class ColdDrink : IItem
    {
        public string Name()
        {
            return "ColdDrink";
        }

        public IPacking Packing()
        {
            return new Bottle();
        }

        public abstract float Price();
    }
}
