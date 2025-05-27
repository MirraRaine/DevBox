namespace UniversityHomeworks.ObjectModellingClass.Patterns.IteratorV2
{
    public class Channel
    {

        private double frequency;
        private ChannelTypeEnum TYPE;

        public Channel(double freq, ChannelTypeEnum type)
        {
            this.frequency = freq;
            this.TYPE = type;
        }

        public double GetFrequency()
        {
            return frequency;
        }

        public ChannelTypeEnum GetTYPE()
        {
            return TYPE;
        }

        public override string ToString()
        {
            return "Frequency=" + this.frequency + ", Type=" + this.TYPE;
        }
    }
}
