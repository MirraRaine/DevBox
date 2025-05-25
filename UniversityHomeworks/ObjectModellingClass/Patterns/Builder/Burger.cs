namespace UniversityHomeworks.ObjectModellingClass.Patterns.Builder
{
    public abstract class Burger : IItem
    {
        public string Name()
        {
            return null;
        }

        public IPacking Packing()
        {
            return new Wrapper();
        }

        public abstract float Price();
    }
}
