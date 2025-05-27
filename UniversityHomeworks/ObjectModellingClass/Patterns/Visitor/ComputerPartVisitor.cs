namespace UniversityHomeworks.ObjectModellingClass.Patterns.Visitor
{
    public interface ComputerPartVisitor
    {
        public void Visit(Computer computer);
        public void Visit(Mouse mouse);
        public void Visit(Keyboard keyboard);
        public void Visit(Monitor monitor);
    }
}
