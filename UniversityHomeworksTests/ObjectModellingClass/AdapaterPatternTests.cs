
using UniversityHomeworks.ObjectModellingClass.Patterns.Adapter;

namespace UniversityHomeworksTests.ObjectModellingClass
{
    [TestClass]
    public class AdapaterPatternTests
    {
        [TestMethod]
        public void Client_Test()
        {
            AudioPlayer audioPlayer = new AudioPlayer();

            audioPlayer.Play("mp3", "beyond the horizon.mp3");
            audioPlayer.Play("mp4", "alone.mp4");
            audioPlayer.Play("vlc", "far far away.vlc");
            audioPlayer.Play("avi", "mind me.avi");
        }
    }
}
