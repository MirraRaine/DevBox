namespace DevExercises
{

    /// <summary>
    /// Custom Stack interface
    /// </summary>
    public interface IStack<T>
    {
        public void Push(T element);

        public T Pop();

        public T Peek();

        public int Size();

        public bool IsEmpty();
    }

    public interface IStack
    {
        public void Push(int element);

        public int Pop();

        public bool IsEmpty();

        public int Peek();

        public int Size();
    }
}
