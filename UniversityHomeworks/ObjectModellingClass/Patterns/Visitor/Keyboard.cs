namespace UniversityHomeworks.ObjectModellingClass.Patterns.Visitor
{
    public class Keyboard : ComputerPart
    {
        public void Accept(ComputerPartVisitor computerPartVisitor)
        {
            computerPartVisitor.Visit(this);
        }
    }
}
