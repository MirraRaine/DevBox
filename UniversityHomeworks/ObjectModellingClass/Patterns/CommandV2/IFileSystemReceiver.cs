namespace UniversityHomeworks.ObjectModellingClass.Patterns.CommandV2
{
    public interface IFileSystemReceiver
    {
        void OpenFile();
        void WriteFile();
        void CloseFile();
    }
}
