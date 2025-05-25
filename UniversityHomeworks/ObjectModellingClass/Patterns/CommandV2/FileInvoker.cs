namespace UniversityHomeworks.ObjectModellingClass.Patterns.CommandV2
{
    public class FileInvoker
    {
        public Command command;

        public FileInvoker(Command c)
        {
            this.command = c;
        }

        public void Execute()
        {
            this.command.Execute();
        }
    }
}
