namespace DevExercises
{
    /// <summary>
    /// A stack implemented using a priority queue assigns unique priorities to elements such that they are dequeued 
    /// in the reverse order of their insertion, maintaining the Last-In-First-Out (LIFO) property. 
    /// Each element pushed onto the stack receives a higher priority than all existing elements, 
    /// ensuring it is always processed first when popped. 
    /// This approach leverages the efficiency and flexibility of priority queues while emulating stack behavior. 
    /// The main operations—push and pop—are handled by inserting with increasing priorities and 
    /// removing the highest-priority element, respectively. 
    /// While this method can be more complex than a traditional array or linked list implementation, 
    /// it offers additional flexibility in managing elements with varying priorities if needed.
    /// </summary>
    public class StackByPriorityQueue
    {
        private int count;
        private PriorityElement[] queue;
        private const int InitialCapacity = 4;

        public StackByPriorityQueue()
        {
            queue = new PriorityElement[InitialCapacity];
            count = 0;
        }

        public void Push(int? element)
        {
            if (count == queue.Length)   // If the array is full, resize it
            {
                ResizeArray();
            }
            queue[count] = new PriorityElement() { Priority = count, Value = element }; // Assign a unique priority based on insertion order
            count++;
        }

        public int? Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Empty stack.");
            }

            int? element = queue[count - 1].Value; // Get the last element
            queue[count - 1] = new PriorityElement(); // Clear the last element
            count--;

            return element;
        }
        private void ResizeArray()
        {
            int newCapacity = queue.Length * 2; // Double the size of the array
            var newArray = new PriorityElement[newCapacity];
            Array.Copy(queue, newArray, count); // Copy existing elements to the new array
            queue = newArray;
        }

        public int Size()
        {
            return count;
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        private class PriorityElement
        {
            public int Priority { get; set; }

            public int? Value { get; set; }

        }
    }
}
