using CustomPair = DevExercises.Pair;

namespace DevExercises
{
    public class StackByPriorityQueuePair
    {
        int count;
        private readonly PriorityQueue<CustomPair> queue;

        public void Push(int element)
        {
            count++;
            queue.Push(new CustomPair(count, element));
        }

        public int Pop()
        {
            if (queue.IsEmpty())
            {
                throw new InvalidOperationException("Empty stack.");
            }
            count--;
            return queue.Pop();
        }

        public int Top()
        {
            CustomPair topElement = queue.Top();
            return topElement.Value;
        }

        public bool IsEmpty()
        {
            return queue.IsEmpty();
        }
    }

    public class PriorityQueue<CustomPair>
    {

        public void Push(CustomPair n)
        {
        }

        public int Pop()
        {
            return 1;
        }

        public CustomPair? Top()
        {
            return default(CustomPair);
        }

        public bool IsEmpty()
        {
            return true;
        }
    }

    public class Pair
    {
        public Pair(int value, int key)
        {
            this.Value = value;
            this.Key = key;
        }

        public int Value { get; set; }
        public int Key { get; set; }
    }
}
