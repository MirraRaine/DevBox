namespace UniversityHomeworks.ObjectModellingClass.Patterns.IteratorV2
{
    public class ChannelCollectionImpl : ChannelCollection
    {

        public List<Channel> channelsList;

        //    public ChannelCollectionImpl(List<Channel> channelsList) {
        //        this.channelsList = channelsList;
        //    }

        public ChannelCollectionImpl()
        {
            channelsList = new List<Channel>();
        }

        public void AddChannel(Channel c)
        {
            this.channelsList.Add(c);
        }

        public void RemoveChannel(Channel c)
        {
            this.channelsList.Remove(c);
        }

        public ChannelIterator Iterator(ChannelTypeEnum type)
        {
            return new ChannelIteratorImpl(type, this.channelsList);
        }
    }
}
