using UniversityHomeworks.ObjectModellingClass.Patterns.IteratorV2;

namespace UniversityHomeworksTests.ObjectModellingClass
{
    [TestClass]
    public class IteratorPatternV2Tests
    {
        [TestMethod]
        public void Client_Test()
        {
            ChannelCollection chan = new ChannelCollectionImpl();
            chan.AddChannel(new Channel(98.5, ChannelTypeEnum.ENGLISH));
            chan.AddChannel(new Channel(99.5, ChannelTypeEnum.HINDI));
            chan.AddChannel(new Channel(100.5, ChannelTypeEnum.FRENCH));
            chan.AddChannel(new Channel(101.5, ChannelTypeEnum.ENGLISH));
            chan.AddChannel(new Channel(102.5, ChannelTypeEnum.HINDI));
            chan.AddChannel(new Channel(103.5, ChannelTypeEnum.FRENCH));
            chan.AddChannel(new Channel(104.5, ChannelTypeEnum.ENGLISH));
            chan.AddChannel(new Channel(105.5, ChannelTypeEnum.HINDI));
            chan.AddChannel(new Channel(106.5, ChannelTypeEnum.FRENCH));

            ChannelIterator baseIterator = chan.Iterator(ChannelTypeEnum.ALL);
            while (baseIterator.HasNext())
            {
                Channel c = baseIterator.Next();
                Console.WriteLine(c.ToString());
            }
            Console.WriteLine("******");
            // Channel Type Iterator
            ChannelIterator englishIterator = chan.Iterator(ChannelTypeEnum.ENGLISH);
            while (englishIterator.HasNext())
            {
                Channel c = englishIterator.Next();
                Console.WriteLine(c.ToString());
            }
        }
    }
}
