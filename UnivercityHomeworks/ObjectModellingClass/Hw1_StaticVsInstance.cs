namespace UniversityHomeworks.ObjectModellingClass
{
    public class Hw1_StaticVsInstance
    {
        // Static variable (shared among all instances)
        public static int count = 1;

        // Instance variable (unique to each instance)
        public int countInstance = 1;

        // Method that always returns true
        public bool GetsTrueAlways()
        {
            return true;
        }

        // Static method that always returns false
        public static bool GetsFalseAlways()
        {
            return false;
        }

        // Method that increments and returns the instance variable
        public int IncrementsAndReturnsInstance()
        {
            return countInstance++;
        }

        // Method that increments and returns the static variable
        public int IncrementsAndReturnsStaticVar()
        {
            return count++;
        }
    }
}
