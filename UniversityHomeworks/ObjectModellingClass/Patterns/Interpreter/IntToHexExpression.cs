
namespace UniversityHomeworks.ObjectModellingClass.Patterns.Interpreter
{
    public class IntToHexExpression : Expression
    {
        private int i;

        public IntToHexExpression(int c)
        {
            this.i = c;
        }

        public string Interpret(InterpreterContext ic)
        {
            return ic.GetHexadecimalFormat(i);
        }
    }
}
