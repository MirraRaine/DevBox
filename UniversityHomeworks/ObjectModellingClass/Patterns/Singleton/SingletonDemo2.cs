namespace UniversityHomeworks.ObjectModellingClass.Patterns.Singleton
{
    public sealed class SingletonDemo2
    {
        private static SingletonDemo2 _instance = null;
        private static readonly object _lock = new object();

        private SingletonDemo2() { }

        public static SingletonDemo2 Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new SingletonDemo2();
                    }
                    return _instance;
                }
            }
        }
    }
}
