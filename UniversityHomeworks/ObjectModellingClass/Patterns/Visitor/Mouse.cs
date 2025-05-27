namespace UniversityHomeworks.ObjectModellingClass.Patterns.Visitor
{
    public class Mouse : ComputerPart
    {
        public void Accept(ComputerPartVisitor computerPartVisitor)
        {
            computerPartVisitor.Visit(this);
        }
    }
}
