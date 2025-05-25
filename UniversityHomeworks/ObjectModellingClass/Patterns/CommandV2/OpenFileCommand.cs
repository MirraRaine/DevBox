namespace UniversityHomeworks.ObjectModellingClass.Patterns.CommandV2
{
    public class OpenFileCommand : Command
    {

        private FileSystemReceiver fileSystem;

        public OpenFileCommand(FileSystemReceiver fs)
        {
            this.fileSystem = fs;
        }

        public void Execute()
        {
            //open command is forwarding request to openFile method
            this.fileSystem.OpenFile();
        }

    }
}
