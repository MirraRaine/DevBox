namespace UniversityHomeworks.ObjectModellingClass.Patterns.Singleton
{
    public sealed class SingletonDemo
    {
        private static volatile SingletonDemo _instance;
        private static readonly object _lock = new object();

        private SingletonDemo() { }

        public static SingletonDemo Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new SingletonDemo();
                        }
                    }
                }
                return _instance;
            }
        }
    }
}
