namespace UniversityHomeworks.ObjectModellingClass.Patterns.ObserverV3
{
    public class Context
    {
        private List<ObserverWorker> observers = new List<ObserverWorker>();
        private string state;

        public string GetState()
        {
            return state;
        }
        public void Attach(ObserverWorker observer)
        {
            observers.Add(observer);
        }

        public void SetState(string state)
        {
            this.state = state;
            NotifyAllObservers();
        }

        public void NotifyAllObservers()
        {
            foreach (ObserverWorker observer in observers)
            {
                observer.Update();
            }
        }
    }
}
