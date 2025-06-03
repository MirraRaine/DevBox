using UniversityHomeworks.ObjectModellingClass.Patterns.Composite;

namespace UniversityHomeworksTests.ObjectModellingClass
{
    [TestClass]
    public class CompositePatternTests
    {
        [TestMethod]
        public void Staff_ShouldReturnCorrectDetails()
        {
            var staff = new Staff("John Doe", "Accounting", 50000);

            string expected = "- Employee [Name: John Doe, Dept: Accounting, Salary: 50000]\n";
            string actual = staff.GetDetails();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Manager_WithNoSubordinates_ShouldReturnOnlyManagerDetails()
        {
            var manager = new Manager("Jane Smith", "Marketing", 80000);

            string expected = "+ Manager [Name: Jane Smith, Dept: Marketing, Salary: 80000]\n";
            string actual = manager.GetDetails();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Manager_WithSubordinates_ShouldReturnHierarchyDetails()
        {
            var manager = new Manager("Tom", "Engineering", 100000);
            var dev1 = new Staff("Alice", "Engineering", 70000);
            var dev2 = new Staff("Bob", "Engineering", 72000);

            manager.Add(dev1);
            manager.Add(dev2);

            string expected =
                "+ Manager [Name: Tom, Dept: Engineering, Salary: 100000]\n" +
                "  - Employee [Name: Alice, Dept: Engineering, Salary: 70000]\n" +
                "  - Employee [Name: Bob, Dept: Engineering, Salary: 72000]\n";

            string actual = manager.GetDetails();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NestedManagers_ShouldFormatCorrectly()
        {
            var ceo = new Manager("Laura", "Executive", 200000);
            var headSales = new Manager("Sara", "Sales", 120000);
            var salesRep = new Staff("Ryan", "Sales", 60000);

            headSales.Add(salesRep);
            ceo.Add(headSales);

            string expected =
                "+ Manager [Name: Laura, Dept: Executive, Salary: 200000]\n" +
                "  + Manager [Name: Sara, Dept: Sales, Salary: 120000]\n" +
                "    - Employee [Name: Ryan, Dept: Sales, Salary: 60000]\n";

            string actual = ceo.GetDetails();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemovingSubordinate_ShouldUpdateOutput()
        {
            var manager = new Manager("Tom", "Engineering", 100000);
            var dev = new Staff("Alice", "Engineering", 70000);

            manager.Add(dev);
            manager.Remove(dev);

            string expected = "+ Manager [Name: Tom, Dept: Engineering, Salary: 100000]\n";
            string actual = manager.GetDetails();

            Assert.AreEqual(expected, actual);
        }
    }
}
