namespace UniversityHomeworks.ObjectModellingClass.Patterns.Adapter
{
    /// <summary>
    /// Concrete implementation of IAdvancedMediaPlayer to play VLC files.
    /// </summary>
    internal class VlcPlayer : IAdvancedMediaPlayer
    {
        /// <inheritdoc/>
        public string PlayVlc(string fileName)
        {
            return $"Playing vlc file. Name: {fileName}";
        }

        /// <inheritdoc/>
        public string PlayMp4(string fileName)
        {
            throw new NotSupportedException("Not supported format");
        }
    }
}
