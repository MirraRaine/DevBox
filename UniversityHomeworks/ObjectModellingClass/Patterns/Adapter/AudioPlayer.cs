namespace UniversityHomeworks.ObjectModellingClass.Patterns.Adapter
{
    public class AudioPlayer : IMediaPlayer
    {

        MediaAdapter mediaAdapter;

        public void Play(string audioType, string fileName)
        {

            //inbuilt support to play mp3 music files
            if (audioType.Equals("mp3", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Playing mp3 file. Name: " + fileName);
            }

            //mediaAdapter is providing support to play other file formats

            else if (audioType.Equals("vlc", StringComparison.OrdinalIgnoreCase) || audioType.Equals("mp4", StringComparison.OrdinalIgnoreCase))
            {
                mediaAdapter = new MediaAdapter(audioType);
                mediaAdapter.Play(audioType, fileName);
            }

            else
            {
                Console.WriteLine("Invalid media. " + audioType + " format not supported");
            }
        }
    }
}
