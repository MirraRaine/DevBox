using System.Text;

namespace DevExercises
{
    /// <summary>
    /// Provides functionality to decode an encoded string.
    /// The encoding pattern follows: <count>[sub_str] ==> The substring 'sub_str' appears count times.
    ///
    /// Example usage:
    /// - Input: "2[a2[b]]"
    ///   Output: "abbabb"
    /// </summary>
    public static class StringDecoder
    {
        public static string Decode(this String encodedString)
        {
            (Stack<char> charStacks, Stack<int?> numStacks) = PopulateStacks(encodedString);

            // Check if the stacks are populated before calling the decoder
            if (charStacks == null || numStacks == null || charStacks.Count == 0 || numStacks.Count == 0)
            {
                throw new InvalidOperationException("Stacks must be properly populated with data.");
            }
            return GetDecodedResult(charStacks, numStacks);
        }

        /// <summary>
        /// Fills two stacks with characters and numbers from the encoded string.
        /// Characters are pushed onto <paramref name="stackCharacters"/>,
        /// and numeric values (converted to nullable integers) are pushed onto <paramref name="stackNumbers"/>.
        /// Stops processing when a ']' character is encountered.
        /// </summary>
        /// <param name="encodedString">The encoded string input.</param>
        /// <returns>A tuple containing the two stacks: (<paramref name="stackCharacters"/>, <paramref name="stackNumbers"/>).</returns>
        private static (Stack<char>, Stack<int?>) PopulateStacks(string encodedString)
        {
            Stack<Char> stackCharacters = new Stack<char>();
            Stack<int?> stackNumbers = new Stack<int?>();

            for (int i = 0; i < encodedString.Length; i++)
            {
                char currentChar = encodedString[i];
                if (currentChar == ']')
                {
                    break;
                }
                if (Char.IsDigit(currentChar))
                {
                    int? element = (int?)Char.GetNumericValue(currentChar);
                    stackNumbers.Push(element);
                }
                else
                {
                    stackCharacters.Push(currentChar);
                }
            }

            return (stackCharacters, stackNumbers);
        }

        /// <summary>
        /// Gets data from the provided character and number stacks.
        /// Assumes that both stacks are properly initialized before calling this method.
        /// </summary>
        /// <param name="stackCharacters">Stack containing characters from the encoded string.</param>
        /// <param name="stackNumbers">Stack containing nullable integers representing counts of substrings.</param>
        /// <returns>The decoded string result.</returns>
        private static string GetDecodedResult(Stack<char> stackCharacters, Stack<int?> stackNumbers)
        {
            StringBuilder result = new StringBuilder();
            while (stackCharacters.Count > 0 && stackNumbers.Count > 0)
            {
                char charElement = stackCharacters.Pop();
                if (!(charElement == '['))
                {
                    result.Append(charElement);
                }
                else
                {
                    int? timesToReplicate = stackNumbers.Pop();

                    // Check if the numeric value is null or less than 1 to prevent runtime errors
                    if (!timesToReplicate.HasValue || timesToReplicate.Value < 1)
                    {
                        throw new InvalidOperationException("Invalid numeric value in stack.");
                    }

                    String segmentToReplicate = result.ToString();

                    while (timesToReplicate > 1)
                    {
                        result.Append(segmentToReplicate);
                        timesToReplicate--;
                    }
                }
            }

            string reversedString = new(result.ToString().Reverse().ToArray());
            return reversedString;
        }
    }
}
