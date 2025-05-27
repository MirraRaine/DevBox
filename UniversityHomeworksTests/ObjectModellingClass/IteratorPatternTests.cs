using UniversityHomeworks.ObjectModellingClass.Patterns.Iterator;

namespace UniversityHomeworksTests.ObjectModellingClass
{
    [TestClass]
    public class IteratorPatternTests
    {
        [TestMethod]
        public void Client_Test()
        {
            Container namesRepository = new NameRepository();

            for (Iterator iter = namesRepository.GetIterator(); iter.HasNext();)
            {
                string name = (string)iter.Next();
                Console.WriteLine("Name : " + name);
            }
        }
    }
}
