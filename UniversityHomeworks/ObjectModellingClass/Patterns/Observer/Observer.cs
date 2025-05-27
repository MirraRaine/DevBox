namespace UniversityHomeworks.ObjectModellingClass.Patterns.Observer
{
    public abstract class Observer
    {
        protected Subject subject;
        public abstract void Update();
    }
}
