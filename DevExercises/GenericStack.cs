namespace DevExercises
{
    /// <summary>
    /// A generic implementation of a stack data structure.
    /// </summary>
    /// <typeparam name="T">The type of elements stored in the stack.</typeparam>
    public class GenericStack<T> : IStack<T>
    {
        private T[] stack; //The array to store the stack's elements.
        private int stackTopIndex = -1; //The index of the top element in the stack. -1 indicates an empty stack.

        /// <summary>
        /// Initializes a new instance of the <see cref="GenericStack{T}"/> class with an initial capacity of 10 elements.
        /// </summary>
        public GenericStack()
        {
            stack = new T[10];
        }

        /// <summary>
        /// Pushes an element onto the top of the stack.
        /// If the stack is full, it automatically extends its size.
        /// </summary>
        /// <param name="element">The element to push onto the stack.</param>
        public void Push(T element)
        {
            if (stackTopIndex < stack.Length - 1)
            {
                stack[++stackTopIndex] = element;
            }
            else
            {
                stack = ExtendStackSize();
                stack[stackTopIndex++] = element;
            }
        }

        /// <summary>
        /// Pops the top element from the stack.
        /// Throws an <see cref="InvalidOperationException"/> if the stack is empty.
        /// </summary>
        /// <returns>The top element of the stack.</returns>
        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Empty stack.");
            }
            T element = stack[stackTopIndex];
            stack[stackTopIndex] = default;
            stackTopIndex--;
            return element;
        }

        /// <summary>
        /// Checks whether the stack is empty.
        /// </summary>
        public bool IsEmpty()
        {
            return stackTopIndex < 0;
        }

        /// <summary>
        /// Returns the top element of the stack without removing it.
        /// Throws an <see cref="InvalidOperationException"/> if the stack is empty.
        /// </summary>
        /// <returns>The top element of the stack.</returns>
        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Empty stack.");
            }
            return stack[stackTopIndex];
        }

        /// <summary>
        /// Returns the number of elements in the stack.
        /// </summary>
        public int Size()
        {
            return stackTopIndex + 1;
        }

        /// <summary>
        /// Extends the size of the internal array used to store the stack's elements.
        /// The new capacity is double the current capacity.
        /// </summary>
        /// <returns>The extended array with twice the original capacity.</returns>
        private T[] ExtendStackSize()
        {
            int newSize = stack.Length * 2;
            T[] extendedStack = new T[newSize];
            Array.Copy(stack, 0, extendedStack, 0, stack.Length);
            return extendedStack;
        }
    }
}
