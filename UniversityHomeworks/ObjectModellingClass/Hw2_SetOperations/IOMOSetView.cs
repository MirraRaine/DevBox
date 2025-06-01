namespace UniversityHomeworks.ObjectModellingClass.Hw2_SetOperations
{
    /// <summary>
    /// Interface representing a view of a set, defining basic operations for sets.
    /// </summary>
    public interface IOMOSetView
    {
        /// <summary>
        /// Checks if the set contains a specific element.
        /// </summary>
        /// <param name="element">The element to check for presence in the set.</param>
        /// <returns>True if the element is present in the set; false otherwise.</returns>
        bool Contains(int? element);

        /// <summary>
        /// Returns an array containing all elements of the set.
        /// </summary>
        /// <returns>An array of elements from the set (order does not matter).</returns>
        int?[] ToArray();

        /// <summary>
        /// Creates and returns a copy of the set.
        /// </summary>
        /// <returns>A new instance representing a copy of the current set.</returns>
        IOMOSetView Copy();
    }
}