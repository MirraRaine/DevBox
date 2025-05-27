namespace UniversityHomeworks.ObjectModellingClass.Patterns.ObserverV2
{
    public interface Observer
    {
        //method to update the observer, used by subject
        public void Update();

        //attach with subject to observe
        public void SetSubject(Subject sub);
    }
}
