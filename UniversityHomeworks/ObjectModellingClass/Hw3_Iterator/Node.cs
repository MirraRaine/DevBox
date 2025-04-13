namespace UniversityHomeworks.ObjectModellingClass.Hw3_Iterator
{
    public class Node
    {
        public Node(int content)
        {
            this.Content = content;
        }

        private Node _left;

        private Node _right;

        public Node Parent { get; private set; }

        public int Content { get; set; }

        public Node Left
        {
            get { return _left; }
            set
            {
                _left = value;
                _left.Parent = this;
            }
        }

        public Node Right {
            get { return _right; }
            set {
                _right = value;
                _right.Parent = this;
            }
        }

        public ICustomIterator InorderIterator()
        {
            return new InorderIterator(this);
        }

        public ICustomIterator PreorderIterator()
        {
            return new PreorderIterator(this);
        }

        public ICustomIterator PostorderIterator()
        {
            return new PostorderIterator(this);
        }
    }
}
