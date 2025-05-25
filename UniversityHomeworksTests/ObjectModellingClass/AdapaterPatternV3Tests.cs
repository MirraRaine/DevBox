using UniversityHomeworks.ObjectModellingClass.Patterns.AdapterV3;

namespace UniversityHomeworksTests.ObjectModellingClass
{
    [TestClass]
    public class AdapaterPatternV3Tests
    {
        [TestMethod]
        public void Client_Test()
        {
            TestClassAdapter();
            TestObjectAdapter();
        }
        private static void TestObjectAdapter()
        {
            ISocketAdapter sockAdapter = new SocketObjectAdapterImpl();
            Volt v3 = GetVolt(sockAdapter, 3);
            Volt v12 = GetVolt(sockAdapter, 12);
            Volt v120 = GetVolt(sockAdapter, 120);
            Console.WriteLine("v3 volts using object Adapter=" + v3.GetVolts());
            Console.WriteLine("v12 volts using object Adapter=" + v12.GetVolts());
            Console.WriteLine("v120 volts using object Adapter=" + v120.GetVolts());
        }

        private static void TestClassAdapter()
        {
            ISocketAdapter sockAdapter = new SocketClassAdapterImpl();
            Volt v3 = GetVolt(sockAdapter, 3);
            Volt v12 = GetVolt(sockAdapter, 12);
            Volt v120 = GetVolt(sockAdapter, 120);
            Console.WriteLine("v3 volts using Class Adapter=" + v3.GetVolts());
            Console.WriteLine("v12 volts using Class Adapter=" + v12.GetVolts());
            Console.WriteLine("v120 volts using Class Adapter=" + v120.GetVolts());
        }

        private static Volt GetVolt(ISocketAdapter sockAdapter, int i)
        {
            switch (i)
            {
                case 3: return sockAdapter.Get3Volt();
                case 12: return sockAdapter.Get12Volt();
                case 120: return sockAdapter.Get120Volt();
                default: return sockAdapter.Get120Volt();
            }
        }
    }
}
