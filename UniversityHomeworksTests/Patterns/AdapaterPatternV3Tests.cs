using UniversityHomeworks.ObjectModellingClass.Patterns.AdapterV3;

namespace UniversityHomeworksTests.Patterns
{
    [TestClass]
    public class AdapaterPatternV3Tests
    {
        [TestMethod]
        public void ClassSocketAdapter_ShouldReturnCorrectVoltages()
        {
            // Arrange
            ISocketAdapter adapter = new ClassSocketAdapter();

            // Act & Assert
            Assert.AreEqual(120, adapter.Get120Volt().Volts);
            Assert.AreEqual(12, adapter.Get12Volt().Volts);
            Assert.AreEqual(3, adapter.Get3Volt().Volts);
        }

        [TestMethod]
        public void ObjectSocketAdapter_ShouldReturnCorrectVoltages()
        {
            // Arrange
            ISocketAdapter adapter = new ObjectSocketAdapter();

            // Act & Assert
            Assert.AreEqual(120, adapter.Get120Volt().Volts);
            Assert.AreEqual(12, adapter.Get12Volt().Volts);
            Assert.AreEqual(3, adapter.Get3Volt().Volts);
        }

        [TestMethod]
        public void Volt_Setter_ShouldUpdateValue()
        {
            // Arrange
            Volt volt = new Volt(100);

            // Act
            volt.Volts = 250;

            // Assert
            Assert.AreEqual(250, volt.Volts);
        }

        [TestMethod]
        public void Socket_ShouldReturnDefaultVolt()
        {
            // Arrange
            Socket socket = new Socket();

            // Act
            Volt result = socket.GetVolt();

            // Assert
            Assert.AreEqual(120, result.Volts);
        }
    }
}
