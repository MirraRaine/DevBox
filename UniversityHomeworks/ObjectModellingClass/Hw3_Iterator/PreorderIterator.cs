namespace UniversityHomeworks.ObjectModellingClass.Hw3_Iterator
{
    /// <summary>
    /// An iterator that performs a pre-order traversal on a binary tree.
    /// </summary>
    /// <remarks>
    /// The traversal order is: 
    /// 1. Visit the current node.
    /// 2. Recursively traverse the left subtree.
    /// 3. Recursively traverse the right subtree.
    /// </remarks>
    internal class PreorderIterator : ICustomIterator
    {
        /// <summary>
        /// The current node in the traversal.
        /// </summary>
        public Node currentNode;

        /// <summary>
        /// Initializes a new instance of the <see cref="PreorderIterator"/> class
        /// with the specified root node.
        /// </summary>
        /// <param name="root">The root node of the binary tree to traverse.</param>
        internal PreorderIterator(Node root)
        {
            currentNode = root;
        }

        /// <summary>
        /// Determines whether there are more nodes to visit in the traversal.
        /// </summary>
        /// <returns>
        /// <c>true</c> if the traversal has more nodes to visit; otherwise, <c>false</c>.
        /// </returns>
        public bool HasNext()
        {
            return currentNode != null;
        }

        /// <summary>
        /// Returns the content of the current node and advances the traversal
        /// to the next node in pre-order.
        /// </summary>
        /// <returns>The content value of the current node.</returns>
        /// <exception cref="InvalidOperationException">
        /// Thrown when there are no more elements to iterate.
        /// </exception>
        public int Next()
        {
            int value;
            value = currentNode.Content;

            if (!HasNext())
            {
                throw new InvalidOperationException(); // Equivalent of NoSuchElementException in Java
            }

            // Traverse the tree in pre-order
            if (currentNode.Left != null)
            {
                currentNode = currentNode.Left;
            }
            else if (currentNode.Right != null)
            {
                currentNode = currentNode.Right;
            }
            else
            {
                Node parent = currentNode.Parent;
                Node child = currentNode;
                while (parent != null && (parent.Right == child || parent.Right == null))
                {
                    child = parent;
                    parent = parent.Parent;
                }
                if (parent == null)
                {
                    currentNode = null;
                }
                else
                {
                    currentNode = parent.Right;
                }
            }
            return value;
        }
    }
}
