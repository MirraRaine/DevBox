namespace UniversityHomeworks.ObjectModellingClass.Patterns.CommandV2
{
    public class FileInvoker
    {
        public ICommand command;

        public FileInvoker(ICommand command)
        {
            this.command = command;
        }

        public void Execute()
        {
            this.command.Execute();
        }
    }
}
