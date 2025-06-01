namespace UniversityHomeworks.ObjectModellingClass.Patterns.CommandV2
{
    public class WriteFileCommand : ICommand
    {
        private IFileSystemReceiver fileSystem;

        public WriteFileCommand(IFileSystemReceiver fs)
        {
            this.fileSystem = fs;
        }

        public void Execute()
        {
            this.fileSystem.WriteFile();
        }
    }
}
