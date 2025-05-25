namespace UniversityHomeworks.ObjectModellingClass.Patterns.CommandV2
{
    public interface FileSystemReceiver
    {
        void OpenFile();
        void WriteFile();
        void CloseFile();
    }
}
