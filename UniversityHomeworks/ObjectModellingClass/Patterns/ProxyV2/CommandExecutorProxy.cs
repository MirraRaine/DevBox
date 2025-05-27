namespace UniversityHomeworks.ObjectModellingClass.Patterns.ProxyV2
{
    public class CommandExecutorProxy : CommandExecutor
    {
        private bool isAdmin;
        private CommandExecutorImpl executor;//тут по фиг, можно и CommandExecutor, т.к. ниже инициализация на  CommandExecutorImpl

        public CommandExecutorProxy(string user, string pwd)
        {
            if ("Pankaj".Equals(user) && "J@urnalD$v".Equals(pwd)) isAdmin = true;
            executor = new CommandExecutorImpl();
        }

        public void RunCommand(string cmd)
        {
            if (isAdmin)
            {
                executor.RunCommand(cmd);
            }
            else
            {
                if (cmd.Trim().StartsWith("rm"))
                {
                    throw new Exception("rm command is not allowed for non-admin users.");
                }
                else
                {
                    executor.RunCommand(cmd);
                }
            }
        }
    }
}
