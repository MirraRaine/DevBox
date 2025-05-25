namespace UniversityHomeworks.ObjectModellingClass.Patterns.CommandV2
{
    public class WriteFileCommand : Command
    {
        private FileSystemReceiver fileSystem;

        public WriteFileCommand(FileSystemReceiver fs)
        {
            this.fileSystem = fs;
        }

        public void Execute()
        {
            this.fileSystem.WriteFile();
        }
    }
}
