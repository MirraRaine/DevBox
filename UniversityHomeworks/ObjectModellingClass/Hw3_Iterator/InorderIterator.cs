namespace UniversityHomeworks.ObjectModellingClass.Hw3_Iterator
{
    /// <summary>
    /// Implements an in-order traversal iterator for a binary tree.
    /// Traverses the tree in the following order:
    /// 1. Visit the left subtree.
    /// 2. Visit the current node.
    /// 3. Visit the right subtree.
    /// </summary>
    internal class InorderIterator : ICustomIterator
    {
        private Node currentNode;

        /// <summary>
        /// Initializes a new instance of the <see cref="InorderIterator"/> class,
        /// starting at the leftmost node of the given binary tree.
        /// </summary>
        /// <param name="root">The root node of the binary tree to traverse.</param>
        internal InorderIterator(Node root)
        {
            currentNode = root;

            if (currentNode == null)
            {
                return;
            }

            // Move to the leftmost node to start in-order traversal
            while (currentNode.Left != null)
            {
                currentNode = currentNode.Left;
            }
        }

        /// <summary>
        /// Determines whether there are more nodes to visit in the in-order traversal.
        /// </summary>
        /// <returns>
        /// <c>true</c> if there are remaining nodes; otherwise, <c>false</c>.
        /// </returns>
        public bool HasNext()
        {
            return currentNode != null;
        }

        /// <summary>
        /// Returns the next value in the in-order traversal sequence and advances the iterator.
        /// </summary>
        /// <returns>
        /// The <see cref="int"/> value of the current node.
        /// </returns>
        /// <exception cref="InvalidOperationException">
        /// Thrown when there are no more nodes to traverse.
        /// </exception>
        public int Next()
        {
            if (!HasNext())
            {
                throw new InvalidOperationException();
            }

            int value = currentNode.Content;

            // Move to the next node in in-order traversal
            if (currentNode.Right != null)
            {
                currentNode = currentNode.Right;
                while (currentNode.Left != null)
                {
                    currentNode = currentNode.Left;
                }
            }
            else
            {
                while (true)
                {
                    if (currentNode.Parent == null)
                    {
                        currentNode = null;
                        break;
                    }

                    if (currentNode.Parent.Left == currentNode)
                    {
                        currentNode = currentNode.Parent;
                        break;
                    }

                    currentNode = currentNode.Parent;
                }
            }

            return value;
        }
    }
}
