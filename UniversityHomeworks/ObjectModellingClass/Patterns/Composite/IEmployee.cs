namespace UniversityHomeworks.ObjectModellingClass.Patterns.Composite
{
    /// <summary>
    /// Represents a common interface for both individual employees (leaves)
    /// and employee groups (composites) in the organizational hierarchy.
    /// </summary>
    public interface IEmployee
    {
        /// <summary>
        /// Returns the formatted employee details with optional indentation for hierarchy.
        /// </summary>
        /// <param name="indent">Indentation level for nested display (default is 0).</param>
        /// <returns>String representation of the employee and its subordinates.</returns>
        string GetDetails(int indent = 0);
    }
}
