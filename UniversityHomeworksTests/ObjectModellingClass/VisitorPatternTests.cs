using UniversityHomeworks.ObjectModellingClass.Patterns.Visitor;

namespace UniversityHomeworksTests.ObjectModellingClass
{
    [TestClass]
    public class VisitorPatternTests
    {
        [TestMethod]
        public void Client_Test()
        {
            ComputerPart computer = new Computer();
            ComputerPart keyboard = new Keyboard();

            Console.WriteLine("keyboard.accept ");
            keyboard.Accept(new ComputerPartDisplayVisitor());

            Console.WriteLine("computer.accept ");
            computer.Accept(new ComputerPartDisplayVisitor());
        }
    }
}
