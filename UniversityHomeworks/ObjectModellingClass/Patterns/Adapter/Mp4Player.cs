namespace UniversityHomeworks.ObjectModellingClass.Patterns.Adapter
{
    /// <summary>
    /// Concrete implementation of IAdvancedMediaPlayer to play MP4 files.
    /// </summary>
    internal class Mp4Player : IAdvancedMediaPlayer
    {
        /// <inheritdoc/>
        public string PlayVlc(string fileName)
        {
            throw new NotSupportedException("Not supported format");
        }

        /// <inheritdoc/>
        public string PlayMp4(string fileName)
        {
            return $"Playing mp4 file. Name: {fileName}";
        }
    }
}
