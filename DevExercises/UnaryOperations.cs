namespace DevExercises
{
    /// <summary>
    /// Provides methods to perform unary operations on integers.
    /// </summary>
    public class UnaryOperations
    {
        /// <summary>
        /// Determines whether the k-th bit of a given number is set (1).
        /// </summary>
        /// <param name="number">The integer which bits are being checked.</param>
        /// <param name="k">The position of the bit to check, starting from 1.</param>
        /// <returns>True if the k-th bit is set; otherwise, false.</returns>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="k"/> is less than 1.
        /// </exception>
        public static bool IsKthBitSet(int number, int k)
        {
            if (k < 1)
            {
                throw new ArgumentException("k must be greater than or equal to 1", nameof(k));
            }

            bool isBitSet = false;

            if ((number & (1 << (k - 1))) != 0)
            {
                isBitSet = true;
            }

            return isBitSet;
        }
    }
}
