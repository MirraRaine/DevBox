using System;
using UniversityHomeworks.ObjectModellingClass.Patterns.Observer;

namespace UniversityHomeworks.ObjectModellingClass.Patterns.ObserverV2
{
    public class MyTopic : ISubject
    {
        private List<IObserver> observers;
        private string message;
        private bool changed;
        private readonly object MUTEX = new object();

        public MyTopic()
        {
            this.observers = new List<IObserver>();
        }

        public void Register(IObserver obj)
        {
            if (obj == null) throw new ArgumentNullException(nameof(obj), "Null Observer");

            lock (MUTEX)
            {
                if (!observers.Contains(obj))
                {
                    observers.Add(obj);
                }
            }
        }

        public void Unregister(IObserver obj)
        {
            lock (MUTEX)
            {
                observers.Remove(obj);
            }
        }

        public void NotifyObservers()
        {
            List<IObserver> observersLocal;

            // Synchronization ensures observers added after state change aren't notified
            lock (MUTEX)
            {
                if (!changed)
                    return;

                observersLocal = new List<IObserver>(this.observers);
                this.changed = false;
            }

            foreach (IObserver observer in observersLocal)
            {
                observer.Update();
            }
        }

        public object GetUpdate(IObserver obj)
        {
            return this.message;
        }

        //method to post message to the topic
        public void PostMessage(string msg)
        {
            Console.WriteLine("Message Posted to Topic:" + msg);
            this.message = msg;
            this.changed = true;
            NotifyObservers();
        }
    }
}
