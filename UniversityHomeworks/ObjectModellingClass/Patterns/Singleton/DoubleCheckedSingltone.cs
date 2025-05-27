namespace UniversityHomeworks.ObjectModellingClass.Patterns.Singleton
{
    public class DoubleCheckedSingleton
    {
        private static volatile DoubleCheckedSingleton _instance;
        private static readonly object _lock = new object();

        private DoubleCheckedSingleton()
        {
            // Private constructor to prevent instantiation
        }

        public static DoubleCheckedSingleton Instance
        {
            get
            {
                var local = _instance;
                if (local == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new DoubleCheckedSingleton();
                        }
                        local = _instance;
                    }
                }
                return local;
            }
        }
    }
}
