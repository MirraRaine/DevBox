namespace UniversityHomeworks.ObjectModellingClass.Patterns.IteratorV2
{
    /*Notice the inner class implementation of iterator interface so that the 
       implementation can’t be used by any other collection. Same approach is 
       followed by collection classes also and all of them have inner class 
       implementation of Iterator interface.*/
    public class ChannelIteratorImpl : ChannelIterator
    {
        private ChannelTypeEnum type;
        private List<Channel> channels;

        private int position;

        public ChannelIteratorImpl(ChannelTypeEnum ty, List<Channel> channelsList)
        {
            this.type = ty;
            this.channels = channelsList;
        }

        public bool HasNext()
        {
            while (position < channels.Count)
            {
                Channel c = channels[position]; // May throw ArgumentOutOfRangeException
                if (c.GetTYPE().Equals(type) || type.Equals(ChannelTypeEnum.ALL))
                {
                    return true;
                }
                else
                    position++;
            }
            return false;
        }

        public Channel Next()
        {
            Channel c = channels[position]; // May throw ArgumentOutOfRangeException
            position++;
            return c;
        }
    }
}
