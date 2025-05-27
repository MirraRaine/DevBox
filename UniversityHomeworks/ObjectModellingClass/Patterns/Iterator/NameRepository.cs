namespace UniversityHomeworks.ObjectModellingClass.Patterns.Iterator
{
    public class NameRepository : Container
    {
        public Iterator GetIterator()
        {
            return new NameIterator();
        }
    }
}
