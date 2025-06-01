namespace UniversityHomeworks.ObjectModellingClass.Patterns.CommandV2
{
    public class OpenFileCommand : ICommand
    {

        private IFileSystemReceiver fileSystemReceiver;

        public OpenFileCommand(IFileSystemReceiver fileSystemReceiver)
        {
            this.fileSystemReceiver = fileSystemReceiver;
        }

        public void Execute()
        {
            //open command is forwarding request to openFile method
            this.fileSystemReceiver.OpenFile();
        }

    }
}
