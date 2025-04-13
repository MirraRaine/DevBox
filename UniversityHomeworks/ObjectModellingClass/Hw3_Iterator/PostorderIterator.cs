namespace UniversityHomeworks.ObjectModellingClass.Hw3_Iterator
{
    /// <summary>
    /// Represents an iterator for traversing a binary tree in post-order.
    /// The iteration follows the post-order traversal pattern:
    /// 1) Traverse the Left subtree recursively.
    /// 2) Traverse the Right subtree recursively.
    /// 3) Visit the root (or current) node.
    /// </summary>
    internal class PostorderIterator : ICustomIterator
    {
        private Node root;
        private Node currentNode;
        private bool hasNext = false;

        /// <summary>
        /// Initializes a new instance of the <see cref="PostorderIterator"/> class.
        /// </summary>
        /// <param name="root">The root node of the binary tree.</param>
        internal PostorderIterator(Node root)
        {
            this.currentNode = root;
            this.root = root;
        }

        /// <summary>
        /// Determines if there is a next element in the post-order traversal.
        /// </summary>
        /// <returns>Returns <c>true</c> if there is a next element, otherwise <c>false</c>.</returns>
        public bool HasNext()
        {
            if (hasNext == true)
            {
                return false;
            }
            return !(currentNode == null);
        }

        /// <summary>
        /// Returns the next element in the post-order traversal.
        /// </summary>
        /// <returns>The content of the current node during traversal.</returns>
        public int Next()
        {
            // Perform post-order traversal and return the content of the node
            if (currentNode == root)
            {
                currentNode = SetNode(root);
            }
            else if (currentNode.Parent.Right != null)
            {
                if (currentNode == currentNode.Parent.Right)
                {
                    currentNode = currentNode.Parent;
                    if (currentNode == root)
                    {
                        hasNext = true;
                        currentNode = root;
                    }
                }
                else
                {
                    currentNode = SetNode(currentNode.Parent.Right);
                }
            }
            else
            {
                currentNode = currentNode.Parent;
            }
            return ReturnContents(currentNode);
        }

        /// <summary>
        /// Recursively sets the current node during traversal.
        /// </summary>
        /// <param name="root">The current node to traverse from.</param>
        /// <returns>The next node in the post-order traversal.</returns>
        public Node SetNode(Node root)
        {
            if (HasNext())
            {
                if (root.Left != null)
                {
                    root = SetNode(root.Left);
                }
                else if (root.Right != null)
                {
                    root = SetNode(root.Right);
                }
            }
            return root;
        }

        /// <summary>
        /// Returns the content of a specified node.
        /// </summary>
        /// <param name="node">The node from which to retrieve the content.</param>
        /// <returns>The content of the specified node.</returns>
        public int ReturnContents(Node node)
        {
            return node.Content;
        }
    }
}
