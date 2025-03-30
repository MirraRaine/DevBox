namespace DevExercises
{
    /// <summary>
    /// A perfect number in mathematics is a positive integer that is equal
    /// to the sum of its proper divisors (excluding itself).
    /// Examples: 
    /// For 6: Proper divisors are 1, 2, 3; Sum = 1 + 2 + 3 = 6 (perfect)
    /// For 28: Proper divisors are 1, 2, 4, 7, 14; Sum = 1 + 2 + 4 + 7 + 14 = 28 (perfect)
    /// For 10:  Proper divisors are  1, 2, and 5; Sum = 1 + 2 + 5 = 8 (not perfect)
    /// </summary>
    public class PerfectNumberChecker
    {
        public static bool IsPerfectNumber(int number)
        {
            if (number == 0)
            {
                return false;
            }
            int sum = 0;
            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }
            if (sum == number)
            {
                Console.WriteLine("It is a perfect number");
                return true;
            }
            else
            {
                Console.WriteLine("It is not a perfect number");
                return false;
            }
        }
    }
}
