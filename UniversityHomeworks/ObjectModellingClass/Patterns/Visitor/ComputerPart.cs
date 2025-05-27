namespace UniversityHomeworks.ObjectModellingClass.Patterns.Visitor
{
    public interface ComputerPart
    {
        public void Accept(ComputerPartVisitor computerPartVisitor);
    }
}
