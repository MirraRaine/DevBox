namespace UniversityHomeworks.ObjectModellingClass.Patterns.Adapter
{
    /// <summary>
    /// Interface representing advanced media players that support specific formats.
    /// </summary>
    internal interface IAdvancedMediaPlayer
    {
        /// <summary>
        /// Plays a VLC media file.
        /// </summary>
        /// <param name="fileName">The name of the file to play.</param>
        public string PlayVlc(string fileName);

        /// <summary>
        /// Plays an MP4 media file.
        /// </summary>
        /// <param name="fileName">The name of the file to play.</param>
        public string PlayMp4(string fileName);
    }
}
