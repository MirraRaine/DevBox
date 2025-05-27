namespace UniversityHomeworks.ObjectModellingClass.Patterns.ObserverV2
{
    public interface Subject
    {
        //methods to register and unregister observers
        public void Register(Observer obj);
        public void Unregister(Observer obj);

        //method to notify observers of change
        public void NotifyObservers();

        //method to get updates from subject
        public object GetUpdate(Observer obj);
    }
}
