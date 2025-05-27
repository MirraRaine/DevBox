namespace UniversityHomeworks.ObjectModellingClass.Patterns.IteratorV2
{
    public interface ChannelIterator
    {
        public bool HasNext();
        public Channel Next();
    }
}
