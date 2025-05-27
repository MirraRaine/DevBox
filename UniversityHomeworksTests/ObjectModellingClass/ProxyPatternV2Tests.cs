using UniversityHomeworks.ObjectModellingClass.Patterns.ProxyV2;

namespace UniversityHomeworksTests.ObjectModellingClass
{
    [TestClass]
    public class ProxyPatternV2Tests
    {
        [TestMethod]
        public void Client_Test()
        {
            CommandExecutor executor = new CommandExecutorProxy("Pankaj", "wrong_pwd");
            try
            {
                executor.RunCommand("dir");
                executor.RunCommand(" rm -rf Patterns.pdf");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception Message::" + e.Message);
            }
        }
    }
}
