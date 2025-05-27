namespace UniversityHomeworks.ObjectModellingClass.Patterns.Visitor
{
    public class Monitor : ComputerPart
    {
        public void Accept(ComputerPartVisitor computerPartVisitor)
        {
            //принять
            computerPartVisitor.Visit(this);
        }
    }
}
