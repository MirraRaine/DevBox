
using UniversityHomeworks.ObjectModellingClass.Patterns.Interpreter;

namespace UniversityHomeworksTests.ObjectModellingClass
{
    [TestClass]
    public class IntepreterPatternTests
    {
        [TestMethod]
        public void Client_Test()
        {
            string str1 = "28 in Binary";
            string str2 = "28 in Hexadecimal";

            InterpreterClient ec = new InterpreterClient(new InterpreterContext()); // this.ic = i;
            Console.WriteLine(str1 + "= " + ec.Interpret(str1)); // i.intepret(str1)
            Console.WriteLine(str2 + "= " + ec.Interpret(str2));
        }
    }
}
