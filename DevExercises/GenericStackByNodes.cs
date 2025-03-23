namespace DevExercises
{
    public class GenericStackByNodes<T> : IStack<T>
    {
        private Node<T>? currentTopNode;
        private int stackSize = 0;

        public GenericStackByNodes()
        {
            stackSize = 0;
            currentTopNode = null;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Empty stack.");
            }
            return currentTopNode!.GetValue();
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Empty stack.");
            }

            Node<T> oldTopNode = this.currentTopNode!;
            this.currentTopNode = this.currentTopNode!.GetPreviousNode();
            stackSize--;
            return oldTopNode.GetValue();
        }

        public void Push(T element)
        {
            Node<T> newTopNode = new Node<T>(element);
            if (!IsEmpty())
            {
                newTopNode!.SetPrevious(currentTopNode!);
            }
            this.currentTopNode = newTopNode;
            stackSize++;
        }

        public int Size()
        {
            return stackSize;
        }

        public bool IsEmpty()
        {
            return currentTopNode == null;
        }

        private class Node<T>(T value)
        {
            private T nodeValue = value;
            private Node<T>? nextNode = null;

            public void SetPrevious(Node<T> nextNode)
            {
                this.nextNode = nextNode;
            }

            public Node<T> GetPreviousNode()
            {
                return this.nextNode!;
            }

            public T GetValue()
            {
                return this.nodeValue;
            }
        }
    }
}