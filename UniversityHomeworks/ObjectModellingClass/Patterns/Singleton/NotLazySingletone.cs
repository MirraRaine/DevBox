namespace UniversityHomeworks.ObjectModellingClass.Patterns.Singleton
{
    public class NotLazySingletone
    {
        public static readonly NotLazySingletone instance = new NotLazySingletone();

        public void Print(string s)
        {
            Console.WriteLine("NotLazySingletone: " + s);
        }
    }
}
