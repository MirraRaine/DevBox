namespace UniversityHomeworks.ObjectModellingClass.Patterns.Interpreter
{
    public class InterpreterClient
    {
        public InterpreterContext ic;
        Expression exp;

        public InterpreterClient(InterpreterContext i)
        {
            this.ic = i;
        }

        public string Interpret(string str)
        {
            //create rules for expressions
            if (str.Contains("Hexadecimal"))
            {
                exp = new IntToHexExpression(int.Parse(str.Substring(0, str.IndexOf(" "))));//вот тут ic становится типом инт
            }
            else if (str.Contains("Binary"))
            {
                exp = new IntToBinaryExpression(int.Parse(str.Substring(0, str.IndexOf(" "))));//вот тут ic становится интом
            }
            else return str;//значит ни то ни сё, возвращаем просто наш стринг : оылмнплмгнл

            return exp.Interpret(ic);//число ic достали, поняла, что пойдём на бинари или на хекседецимал и обращаемся уже к конкретному экспрешону
        }
    }
}
