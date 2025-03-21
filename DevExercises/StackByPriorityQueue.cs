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
        private (int priority, int? value)[] queue;
        private int count;
        private const int InitialCapacity = 4;

        public StackByPriorityQueue()
        {
            queue = new (int, int?)[InitialCapacity];
            count = 0;
        }

        public void Push(int? element)
        {
            if (count == queue.Length)   // If the array is full, resize it
            {
                ResizeArray();
            }
            queue[count] = (count, element); // Assign a unique priority based on insertion order
            count++;
        }


        public int? Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Empty stack.");
            }

            int index = FindMaxPriorityIndex(); // Find the element with the highest priority
            (int priority, int? element) = queue[index];

            // Shift elements to fill the gap left by removing the top item
            for (int i = index; i < count - 1; i++)
            {
                queue[i] = queue[i + 1];
            }

            queue[count - 1] = default((int, int?)); // Clear the last element
            count--;

            return element;
        }

        private int FindMaxPriorityIndex()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("Empty stack.");
            }

            int maxIndex = 0;
            for (int i = 1; i < count; i++)
            {
                if (queue[i].priority > queue[maxIndex].priority)
                {
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        private void ResizeArray()
        {
            int newCapacity = queue.Length * 2; // Double the size of the array
            var newArray = new (int, int?)[newCapacity];
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
    }
}
