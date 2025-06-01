namespace UniversityHomeworks.ObjectModellingClass.Patterns.CommandV2
{
    public class UnixFileSystemReceiver : IFileSystemReceiver
    {
        public void OpenFile()
        {
            Console.WriteLine("Opening file in unix OS");
        }

        public void WriteFile()
        {
            Console.WriteLine("Writing file in unix OS");
        }

        public void CloseFile()
        {
            Console.WriteLine("Closing file in unix OS");
        }
    }
}
