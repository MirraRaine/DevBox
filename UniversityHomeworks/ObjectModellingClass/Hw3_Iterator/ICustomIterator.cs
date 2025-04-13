namespace UniversityHomeworks.ObjectModellingClass.Hw3_Iterator
{
    /// <summary>
    /// Defines a custom iterator interface for traversing a binary tree.
    /// </summary>
    public interface ICustomIterator
    {
        /// <summary>
        /// Determines whether there are more nodes to visit in the traversal.
        /// </summary>
        /// <returns>
        /// <c>true</c> if there are more nodes to visit; otherwise, <c>false</c>.
        /// </returns>
        bool HasNext();

        /// <summary>
        /// Returns the next node's value in the traversal sequence.
        /// </summary>
        /// <returns>
        /// The content value of the next node.
        /// </returns>
        int Next();
    }
}
