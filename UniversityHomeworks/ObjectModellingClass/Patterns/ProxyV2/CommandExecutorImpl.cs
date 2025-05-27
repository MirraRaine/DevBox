using System.Diagnostics;

namespace UniversityHomeworks.ObjectModellingClass.Patterns.ProxyV2
{
    public class CommandExecutorImpl : CommandExecutor
    {
        public void RunCommand(string cmd)
        {
            ////in java was : some heavy implementation
            //Runtime.getRuntime().exec(cmd);
            //Console.WriteLine("'" + cmd + "' command executed.");

            // Execute command using Process
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";         // use "bash" on Unix-based systems
            process.StartInfo.Arguments = "/c " + cmd;      // /c tells cmd to run and exit
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.UseShellExecute = false;

            process.Start();

            Console.WriteLine($"'{cmd}' command executed.");
        }
    }
}
