namespace UniversityHomeworks.ObjectModellingClass.Patterns.Adapter
{
    /// <summary>
    /// Client class that uses the IMediaPlayer interface to play various media types.
    /// Delegates non-mp3 formats to a MediaAdapter.
    /// </summary>
    public class AudioPlayer : IMediaPlayer
    {
        private MediaAdapter? mediaAdapter;

        /// <inheritdoc/>
        public string Play(string audioType, string fileName)
        {
            if (audioType.Equals("mp3", StringComparison.OrdinalIgnoreCase))
            {
                return $"Playing mp3 file. Name: {fileName}";
            }
            else if (audioType.Equals("vlc", StringComparison.OrdinalIgnoreCase) ||
                     audioType.Equals("mp4", StringComparison.OrdinalIgnoreCase))
            {
                this.mediaAdapter = new MediaAdapter(audioType);
                return this.mediaAdapter.Play(audioType, fileName);
            }
            else
            {
                throw new NotSupportedException("Invalid media. " + audioType + " format not supported");
            }
        }
    }
}
