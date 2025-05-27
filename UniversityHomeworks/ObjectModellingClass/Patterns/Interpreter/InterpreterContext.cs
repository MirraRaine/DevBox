namespace UniversityHomeworks.ObjectModellingClass.Patterns.Interpreter
{
    public class InterpreterContext
    {
        public string GetBinaryFormat(int i)
        {
            return Convert.ToString(i, 2);
        }

        public string GetHexadecimalFormat(int i)
        {
            return Convert.ToString(i, 2);
        }
    }
}
