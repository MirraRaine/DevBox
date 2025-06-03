namespace UniversityHomeworks.ObjectModellingClass.Patterns.Composite
{
    /// <summary>
    /// Represents a manager who can have subordinates (either staff or other managers).
    /// </summary>
    public class Manager : IEmployee
    {
        private readonly string name;
        private readonly string dept;
        private readonly int salary;
        private readonly List<IEmployee> subordinates = new();

        /// <summary>
        /// Initializes a new instance of the <see cref="Manager"/> class.
        /// </summary>
        public Manager(string name, string dept, int salary)
        {
            this.name = name;
            this.dept = dept;
            this.salary = salary;
        }

        /// <summary>
        /// Adds a subordinate to this manager.
        /// </summary>
        public void Add(IEmployee employee) => subordinates.Add(employee);

        /// <summary>
        /// Removes a subordinate from this manager.
        /// </summary>
        public void Remove(IEmployee employee) => subordinates.Remove(employee);

        /// <inheritdoc/>
        public string GetDetails(int indent = 0)
        {
            var result = $"{new string(' ', indent)}+ Manager [Name: {name}, Dept: {dept}, Salary: {salary}]\n";
            foreach (var subordinate in subordinates)
            {
                result += subordinate.GetDetails(indent + 2);
            }
            return result;
        }
    }
}
