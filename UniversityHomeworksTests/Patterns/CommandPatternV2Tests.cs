using UniversityHomeworks.ObjectModellingClass.Patterns.CommandV2;

namespace UniversityHomeworksTests.Patterns
{
    [TestClass]
    public class CommandPatternV2Tests
    {
        [TestMethod]
        public void Client_Test()
        {
            //Creating the receiver object
            //FileSystemReceiver fs = FileSystemReceiverUtil.getUnderlyingFileSystem();
            //FileSystemReceiver fsr = new UnixFileSystemReceiver();
            IFileSystemReceiver fsr = new WindowsFileSystemReceiver();

            //creating command and associating with receiver
            OpenFileCommand openFileCommand = new OpenFileCommand(fsr);

            //Creating invoker and associating with Command
            FileInvoker file = new FileInvoker(openFileCommand);

            //perform action on invoker object
            file.Execute();

            WriteFileCommand writeFileCommand = new WriteFileCommand(fsr);
            file = new FileInvoker(writeFileCommand);
            file.Execute();

            CloseFileCommand closeFileCommand = new CloseFileCommand(fsr);
            file = new FileInvoker(closeFileCommand);
            file.Execute();
        }
    }
}
