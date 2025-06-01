namespace UniversityHomeworks.ObjectModellingClass.Patterns.ObserverV2
{
    public interface IObserver
    {
        //method to update the observer, used by subject
        public void Update();

        //attach with subject to observe
        public void SetSubject(ISubject sub);
    }
}
