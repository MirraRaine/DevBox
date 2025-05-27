
namespace UniversityHomeworks.ObjectModellingClass.Patterns.Interpreter
{
    public class IntToBinaryExpression : Expression
    {
        private int i;

        public IntToBinaryExpression(int c)
        {
            this.i = c;
        }

        public string Interpret(InterpreterContext ic)
        {
            return ic.GetBinaryFormat(this.i);
        }
    }
}
