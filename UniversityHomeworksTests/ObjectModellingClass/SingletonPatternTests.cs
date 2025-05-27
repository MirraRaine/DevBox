using UniversityHomeworks.ObjectModellingClass.Patterns.Singleton;

namespace UniversityHomeworksTests.ObjectModellingClass
{
    [TestClass]
    public class SingletonPatternTests
    {
        [TestMethod]
        public void Client_Test()
        {
            //illegal construct
            //Compile Time Error: The constructor SingleObject() is not visible
            // SingleObject object = new SingleObject();//has private access

            //Get the only object available

            var obj = SingleObject.GetInstance();

            //show the message
            obj.ShowMessage();

            NotLazySingletone s = new NotLazySingletone();
        }
    }
}
