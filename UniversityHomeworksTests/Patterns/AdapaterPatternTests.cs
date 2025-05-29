
using UniversityHomeworks.ObjectModellingClass.Patterns.Adapter;

namespace UniversityHomeworksTests.Patterns
{
    [TestClass]
    public class AdapaterPatternTests
    {
        public required AudioPlayer audioPlayer;

        [TestInitialize]
        public void Setup()
        {
            this.audioPlayer = new AudioPlayer();
        }

        [TestMethod]
        public void Play_WithMp3Format_ReturnsExpectedOutput()
        {
            // Arrange
            string audioType = "mp3";
            string fileName = "test.mp3";

            // Act
            string result = this.audioPlayer.Play(audioType, fileName);

            // Assert
            Assert.AreEqual("Playing mp3 file. Name: test.mp3", result);
        }

        [TestMethod]
        public void Play_WithMp4Format_UsesMediaAdapterAndReturnsExpectedOutput()
        {
            // Arrange
            string audioType = "mp4";
            string fileName = "movie.mp4";

            // Act
            string result = this.audioPlayer.Play(audioType, fileName);

            // Assert
            Assert.AreEqual("Playing mp4 file. Name: movie.mp4", result);
        }

        [TestMethod]
        public void Play_WithVlcFormat_UsesMediaAdapterAndReturnsExpectedOutput()
        {
            // Arrange
            string audioType = "vlc";
            string fileName = "clip.vlc";

            // Act
            string result = this.audioPlayer.Play(audioType, fileName);

            // Assert
            Assert.AreEqual("Playing vlc file. Name: clip.vlc", result);
        }

        [TestMethod]
        [ExpectedException(typeof(NotSupportedException))]
        public void Play_WithUnsupportedFormat_ThrowsNotSupportedException()
        {
            // Arrange
            string audioType = "avi";
            string fileName = "video.avi";

            // Act
            this.audioPlayer.Play(audioType, fileName);

            // Assert is handled by ExpectedException
        }
    }
}
