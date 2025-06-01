namespace UniversityHomeworks.ObjectModellingClass.Patterns.CommandV2
{
    public class FileSystemReceiverUtil
    {
        public static IFileSystemReceiver GetUnderlyingFileSystem()
        {
            string osName = System.Runtime.InteropServices.RuntimeInformation.OSDescription;//System.GetProperty("os.name");

            Console.WriteLine("Underlying OS is:" + osName);
            if (osName.Contains("Windows"))
            {
                return new WindowsFileSystemReceiver();
            }
            else
            {
                return new UnixFileSystemReceiver();
            }
        }

    }
}
