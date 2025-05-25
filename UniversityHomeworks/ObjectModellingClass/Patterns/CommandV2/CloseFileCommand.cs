namespace UniversityHomeworks.ObjectModellingClass.Patterns.CommandV2
{
    public class CloseFileCommand : Command
    {
        private FileSystemReceiver fileSystem;

        public CloseFileCommand(FileSystemReceiver fs)
        {
            this.fileSystem = fs;
        }

        public void Execute()
        {
            this.fileSystem.CloseFile();
        }
    }
}
