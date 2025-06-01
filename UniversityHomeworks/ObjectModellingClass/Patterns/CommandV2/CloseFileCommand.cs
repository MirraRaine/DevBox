namespace UniversityHomeworks.ObjectModellingClass.Patterns.CommandV2
{
    public class CloseFileCommand : ICommand
    {
        private IFileSystemReceiver fileSystem;

        public CloseFileCommand(IFileSystemReceiver fs)
        {
            this.fileSystem = fs;
        }

        public void Execute()
        {
            this.fileSystem.CloseFile();
        }
    }
}
