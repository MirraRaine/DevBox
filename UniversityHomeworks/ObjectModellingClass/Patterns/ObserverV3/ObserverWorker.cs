namespace UniversityHomeworks.ObjectModellingClass.Patterns.ObserverV3
{
    public abstract class ObserverWorker
    {
        protected Context ctx;

        public abstract void Update();
    }
}
