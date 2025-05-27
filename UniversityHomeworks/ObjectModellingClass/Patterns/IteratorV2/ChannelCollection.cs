namespace UniversityHomeworks.ObjectModellingClass.Patterns.IteratorV2
{
    public interface ChannelCollection
    {
        public void AddChannel(Channel c);

        public void RemoveChannel(Channel c);

        public ChannelIterator Iterator(ChannelTypeEnum type);
    }
}
