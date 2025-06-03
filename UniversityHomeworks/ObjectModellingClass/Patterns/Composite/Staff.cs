namespace UniversityHomeworks.ObjectModellingClass.Patterns.Composite
{
    /// <summary>
    /// Represents an individual employee who does not have subordinates.
    /// </summary>
    public class Staff : IEmployee
    {
        private readonly string name;
        private readonly string dept;
        private readonly int salary;

        /// <summary>
        /// Initializes a new instance of the <see cref="Staff"/> class.
        /// </summary>
        public Staff(string name, string dept, int salary)
        {
            this.name = name;
            this.dept = dept;
            this.salary = salary;
        }

        /// <inheritdoc/>
        public string GetDetails(int indent = 0)
        {
            return $"{new string(' ', indent)}- Employee [Name: {name}, Dept: {dept}, Salary: {salary}]\n";
        }
    }
}
