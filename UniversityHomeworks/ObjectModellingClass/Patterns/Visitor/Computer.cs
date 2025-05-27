namespace UniversityHomeworks.ObjectModellingClass.Patterns.Visitor
{
    public class Computer : ComputerPart
    {
        ComputerPart[]
        parts; //поле частей компьютера

        public Computer()
        {
            parts = new ComputerPart[] { new Mouse(), new Keyboard(), new Monitor() };
        }

        public void Accept(ComputerPartVisitor computerPartVisitor)
        {
            for (int i = 0; i < parts.Length; i++)
            {
                parts[i].Accept(computerPartVisitor);//эту же операцию делаем в мейне computerPartDisplayingVisitor.visit(this)

            }
            computerPartVisitor.Visit(this);//без этого посетит только мышь, клаву и монитор.
        }
    }
}
