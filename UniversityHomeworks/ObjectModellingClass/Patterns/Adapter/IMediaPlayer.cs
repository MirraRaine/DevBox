namespace UniversityHomeworks.ObjectModellingClass.Patterns.Adapter
{
    /// <summary>
    /// Target interface expected by clients (e.g., AudioPlayer).
    /// Provides a method to play audio files of a given type.
    /// </summary>
    public interface IMediaPlayer
    {
        /// <summary>
        /// Plays a media file of the specified audio type.
        /// </summary>
        /// <param name="audioType">The format of the audio (e.g., mp3, mp4, vlc).</param>
        /// <param name="fileName">The name of the file to play.</param>
        string Play(string audioType, string fileName);
    }
}
