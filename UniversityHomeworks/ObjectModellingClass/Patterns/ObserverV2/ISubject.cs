namespace UniversityHomeworks.ObjectModellingClass.Patterns.ObserverV2
{
    public interface ISubject
    {
        //methods to register and unregister observers
        public void Register(IObserver obj);
        public void Unregister(IObserver obj);

        //method to notify observers of change
        public void NotifyObservers();

        //method to get updates from subject
        public object GetUpdate(IObserver obj);
    }
}
