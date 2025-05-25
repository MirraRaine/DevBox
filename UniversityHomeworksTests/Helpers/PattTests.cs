using System.Text;
using System.Text.RegularExpressions;

namespace UniversityHomeworksTests.Helpers
{
    [TestClass]
    public class PattTests
    {
        private static string REGEXSPACE = "[ \\t\\n\\x0B\\f\\r]";

        [TestMethod]
        public void PattTest()
        {
            Regex regex = new Regex("a*b");
            string input = "aabtextaabtextabtextb the end";
            StringBuilder buffer = new StringBuilder();
            int lastIndex = 0;

            foreach (Match match in regex.Matches(input))
            {
                // Append everything before this match
                buffer.Append(input, lastIndex, match.Index - lastIndex);
                buffer.Append("-");  // Replace match with "-"
                lastIndex = match.Index + match.Length;
            }

            // Append the remainder of the string
            buffer.Append(input.Substring(lastIndex));

            Console.WriteLine(buffer.ToString());
            // Output: "-text-text-text- the end"
        }

        [TestMethod]
        public void RegexTest()
        {
            string robotPattern = @"\s+";
            string robot = " Robot345/674";

            // Equivalent to Java's List list = new ArrayList();
            List<object> list = new List<object>();

            // Trim and take substring
            string str = robot.Trim().Substring(0, 5);
            Console.WriteLine("str " + str);
            Console.WriteLine(str.Equals("Robot"));

            // Compile regex
            Regex regex = new Regex(robotPattern);

            // Check if entire string matches the pattern
            Match match = regex.Match(robot);
            Console.WriteLine(match.Success && match.Length == robot.Length);

            // This loop will only run if the entire string is whitespace (like in Java's matcher.matches())
            while (match.Success && match.Length == robot.Length)
            {
                Console.WriteLine("while");
                Console.WriteLine(match.Index);
                Console.WriteLine(match.Index + match.Length);
                match = match.NextMatch(); // Will break after one iteration if fully matched
            }

            Console.WriteLine(IsLoggedIn(robot));
        }

        private static bool IsLoggedIn(string login)
        {
            string[] parts = Regex.Split(login.Trim(), REGEXSPACE);
            if (parts.Length > 0 && parts[0] == "Robot")
            {
                string text = login.Trim();
                Console.WriteLine(Regex.Split(text, REGEXSPACE)[0] == "Robot");

                int sum = 0;
                for (int i = 0; i < login.Length; i++)
                {
                    sum += login[i];
                    Console.WriteLine(login[i]);
                }
            }

            return false;
        }
    }
}
