using System;
using UniversityHomeworks.ObjectModellingClass.Patterns.Observer;

namespace UniversityHomeworks.ObjectModellingClass.Patterns.ObserverV2
{
    public class MyTopic : Subject
    {
        private List<Observer> observers;
        private string message;
        private bool changed;
        private readonly object MUTEX = new object();

        public MyTopic()
        {
            this.observers = new List<Observer>();
        }

        public void Register(Observer obj)
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

        public void Unregister(Observer obj)
        {
            lock (MUTEX)
            {
                observers.Remove(obj);
            }
        }

        public void NotifyObservers()
        {
            List<Observer> observersLocal;

            // Synchronization ensures observers added after state change aren't notified
            lock (MUTEX)
            {
                if (!changed)
                    return;

                observersLocal = new List<Observer>(this.observers);
                this.changed = false;
            }

            foreach (Observer observer in observersLocal)
            {
                observer.Update();
            }
        }

        public object GetUpdate(Observer obj)
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
