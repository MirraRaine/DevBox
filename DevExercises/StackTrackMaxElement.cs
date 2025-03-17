namespace DevExercises
{
    /// <summary>
    /// Represents a custom stack implementation that tracks the maximum element 
    /// at any point in the stack's state.
    /// </summary>
    public class StackTrackMaxElement : IStack<int>
    {
        private readonly List<int> stack; // Stores elements of the stack
        private readonly List<int> trackingMaxElements; // Tracks maximum elements
        private int stackTopIndex;
        private int currentMaximumElement;

        /// <summary>
        /// Initializes a new instance of the <see cref="StackTrackMaxElement"/> class.
        /// </summary>
        public StackTrackMaxElement()
        {
            stackTopIndex = -1;
            stack = new List<int>();
            trackingMaxElements = new List<int>();
        }

        /// <summary>
        /// Adds an element to the stack and updates the maximum tracking list.
        /// </summary>
        public void Push(int element)
        {
            if (stackTopIndex == -1)
            {
                currentMaximumElement = element;
            }
            stack.Add(element);
            stackTopIndex++;

            int peekedElement = this.Peek();
            if (peekedElement > currentMaximumElement)
            {
                currentMaximumElement = peekedElement;
                trackingMaxElements.Add(currentMaximumElement);
            }
            else
            {
                trackingMaxElements.Add(currentMaximumElement);
            }
        }

        /// <summary>
        /// Removes and returns the top element from the stack.
        /// </summary>
        public int Pop()
        {
            if (this.IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty");
            }

            int element = this.Peek();
            stack.RemoveAt(stackTopIndex);
            trackingMaxElements.RemoveAt(stackTopIndex);
            stackTopIndex--;

            return element;
        }

        /// <summary>
        /// Returns the top element of the stack without removing it.
        /// </summary>
        public int Peek()
        {
            if (this.IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty");
            }
            return stack[this.stackTopIndex];
        }

        /// <summary>
        /// Gets the number of elements currently in the stack.
        /// </summary>
        public int Size() => this.stackTopIndex + 1;

        /// <summary>
        /// Determines whether the stack is empty.
        /// </summary>
        public bool IsEmpty() => stackTopIndex < 0;

        /// <summary>
        /// Retrieves the list tracking the maximum elements of the stack.
        /// </summary>
        public List<int> GetTrackingMaximumElementsList() => trackingMaxElements;
    }

    /// <summary>
    /// Custom Stack interface
    /// </summary>
    public interface IStack<T>
    {
        void Push(T item);
        T Pop();
        T Peek();
        T Size();
        bool IsEmpty();
    }
}
