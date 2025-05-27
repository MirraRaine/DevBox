namespace UniversityHomeworks.ObjectModellingClass.Patterns.Interpreter
{
    public interface Expression
    {
        string Interpret(InterpreterContext ic);
    }
}
