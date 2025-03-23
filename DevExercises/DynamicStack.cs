using System.Collections;
namespace DevExercises
{
    public class DynamicStack : Stack
    {
        private int[] stack;
        private int stackTopIndex;

        public DynamicStack()
        {
            stackTopIndex = -1;
            stack = new int[10];
        }

        public override void Push(object? obj)
        {
            int element = Convert.ToInt32(obj);
            if (stackTopIndex < stack.Length - 1)
            {
                stack[++stackTopIndex] = element;
            }
            else
            {
                stack = extendStackSize();
                stack[stackTopIndex++] = element;
            }
        }

        public override object Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Empty stack.");
            }
            int element = stack[stackTopIndex];
            stack[stackTopIndex] = 0;
            stackTopIndex--;
            return element;
        }

        public int Size()
        {
            return stackTopIndex + 1;
        }

        public bool IsEmpty()
        {
            return stackTopIndex < 0;
        }

        public override object Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Empty stack.");
            }
            return stack[stackTopIndex];
        }

        private int[] ExtendStackSize()
        {
            int[] stackWithExtendedSize = new int[stack.Length * 2];
            for (int i = 0; i < stack.Length; i++)
            {
                stackWithExtendedSize[i] = stack[i];
            }
            return stackWithExtendedSize;
        }
    }
}
