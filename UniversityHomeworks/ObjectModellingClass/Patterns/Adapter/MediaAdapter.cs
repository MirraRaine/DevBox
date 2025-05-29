namespace UniversityHomeworks.ObjectModellingClass.Patterns.Adapter
{
    /// <summary>
    /// Adapter class that allows AudioPlayer (which uses IMediaPlayer) to
    /// play formats supported by IAdvancedMediaPlayer (e.g., mp4, vlc).
    /// </summary>
    public class MediaAdapter : IMediaPlayer
    {
        private readonly IAdvancedMediaPlayer advancedMusicPlayer;
        private readonly string format;

        /// <summary>
        /// Initializes a new instance of the MediaAdapter with the given format.
        /// </summary>
        /// <param name="audioType">The audio format to adapt (mp4 or vlc).</param>
        public MediaAdapter(string audioType)
        {
            format = audioType.ToLowerInvariant();
            advancedMusicPlayer = format switch
            {
                "vlc" => new VlcPlayer(),
                "mp4" => new Mp4Player(),
                _ => throw new NotSupportedException($"Format {audioType} not supported.")
            };
        }

        public string Play(string audioType, string fileName)
        {
            switch (format)
            {
                case "vlc":
                    return advancedMusicPlayer.PlayVlc(fileName);
                case "mp4":
                    return advancedMusicPlayer.PlayMp4(fileName);
                default:
                    throw new NotSupportedException("Not supported format");
            }
        }
    }
}
