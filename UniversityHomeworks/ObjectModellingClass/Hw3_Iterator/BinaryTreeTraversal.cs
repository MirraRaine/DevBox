using System.Text;

namespace UniversityHomeworks.ObjectModellingClass.Hw3_Iterator
{
    /// <summary>
    /// Provides static methods for traversing a binary tree using different traversal strategies.
    /// </summary>
    public class BinaryTreeTraversal
    {
        /// <summary>
        /// Performs a pre-order traversal of the binary tree starting from the specified node.
        /// </summary>
        /// <param name="root">The root node to start traversal from.</param>
        /// <returns>
        /// A space-separated string representing the node values in pre-order traversal order.
        /// </returns>
        public static string PreOrder(Node root)
        {
            if (root == null)
            {
                return "";
            }

            StringBuilder sb = new StringBuilder();
            sb.Append(root.Content);
            sb.Append(' ');
            sb.Append(PreOrder(root.Left));
            sb.Append(PreOrder(root.Right));
            return sb.ToString();
        }

        /// <summary>
        /// Performs an in-order traversal of the binary tree starting from the specified node.
        /// </summary>
        /// <param name="root">The root node to start traversal from.</param>
        /// <returns>
        /// A space-separated string representing the node values in in-order traversal order.
        /// </returns>
        public static string InOrder(Node root)
        {
            if (root == null)
            {
                return "";
            }

            StringBuilder sb = new StringBuilder();
            sb.Append(InOrder(root.Left));
            sb.Append(root.Content);
            sb.Append(' ');
            sb.Append(InOrder(root.Right));
            return sb.ToString();
        }

        /// <summary>
        /// Performs a post-order traversal of the binary tree starting from the specified node.
        /// </summary>
        /// <param name="n">The root node to start traversal from.</param>
        /// <returns>
        /// A space-separated string representing the node values in post-order traversal order.
        /// </returns>
        public static string PostOrder(Node root)
        {
            if (root == null)
            {
                return "";
            }

            StringBuilder sb = new StringBuilder();
            sb.Append(PostOrder(root.Left));
            sb.Append(PostOrder(root.Right));
            sb.Append(root.Content);
            sb.Append(' ');
            return sb.ToString();
        }
    }
}
