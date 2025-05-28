using UniversityHomeworks.ObjectModellingClass.Patterns.AbstractFactoryV2;

namespace UniversityHomeworksTests.ObjectModellingClass
{
    /// <summary>
    /// Test class to validate functionality of the <see cref="Patterns.AbstractFactory"/> pattern.
    /// </summary>
    [TestClass]
    public class AbstractFactoryPatternV2Tests
    {
        [TestMethod]
        public void Client_PCFactory_ShouldReturnCorrectSpecifications()
        {
            // Arrange
            IComputerAbstractFactory pcFactory = new PCFactory("2GB", "500GB", "2.4GHz");

            // Act
            Computer pc = pcFactory.CreateComputer();

            // Assert
            Assert.AreEqual("2GB", pc.GetRAM());
            Assert.AreEqual("500GB", pc.GetHDD());
            Assert.AreEqual("2.4GHz", pc.GetCPU());

            Assert.AreEqual("RAM=2GB, HDD=500GB, CPU=2.4GHz", pc.ToString());
        }

        [TestMethod]
        public void Client_ServerFactory_ShouldReturnCorrectSpecifications()
        {
            // Arrange
            IComputerAbstractFactory serverFactory = new ServerFactory("16GB", "1TB", "2.9GHz");

            // Act
            Computer server = serverFactory.CreateComputer();

            // Assert
            Assert.AreEqual("16GB", server.GetRAM());
            Assert.AreEqual("1TB", server.GetHDD());
            Assert.AreEqual("2.9GHz", server.GetCPU());

            Assert.AreEqual("RAM=16GB, HDD=1TB, CPU=2.9GHz", server.ToString());
        }

        [TestMethod]
        public void Server_ShouldReturnCorrectSpecifications()
        {
            // Arrange
            string expectedRam = "32GB";
            string expectedHdd = "1TB";
            string expectedCpu = "Intel Xeon";

            Server server = new Server(expectedRam, expectedHdd, expectedCpu);

            // Act & Assert
            Assert.AreEqual(expectedRam, server.GetRAM());
            Assert.AreEqual(expectedHdd, server.GetHDD());
            Assert.AreEqual(expectedCpu, server.GetCPU());
        }

        [TestMethod]
        public void Server_ToString_ShouldReturnFormattedSpecs()
        {
            // Arrange
            Server server = new Server("64GB", "2TB", "AMD EPYC");

            // Act
            string result = server.ToString();

            // Assert
            Assert.AreEqual("RAM=64GB, HDD=2TB, CPU=AMD EPYC", result);
        }

        [TestMethod]
        public void ServerFactory_ShouldCreateServerWithCorrectSpecs()
        {
            // Arrange
            string ram = "16GB";
            string hdd = "512GB";
            string cpu = "Intel i9";

            IComputerAbstractFactory factory = new ServerFactory(ram, hdd, cpu);

            // Act
            Computer server = factory.CreateComputer();

            // Assert
            Assert.AreEqual(ram, server.GetRAM());
            Assert.AreEqual(hdd, server.GetHDD());
            Assert.AreEqual(cpu, server.GetCPU());
        }

        [TestMethod]
        public void ServerFactory_ToString_ShouldReturnCorrectSummary()
        {
            // Arrange
            ServerFactory factory = new ServerFactory("8GB", "256GB", "Intel i7");

            // Act
            string summary = factory.ToString();

            // Assert
            Assert.AreEqual("RAM=8GB, HDD=256GB, CPU=Intel i7", summary);
        }

        [TestMethod]
        public void Client_ServerFactory_ShouldReturnCorrectDefaultSpecifications()
        {
            // Arrange
            IComputerAbstractFactory factory = new ServerFactory();

            // Act
            Computer server = factory.CreateComputer();

            // Assert
            Assert.AreEqual("8GB", server.GetRAM());
            Assert.AreEqual("256GB", server.GetHDD());
            Assert.AreEqual("Intel i7", server.GetCPU());

            Assert.AreEqual("RAM=8GB, HDD=256GB, CPU=Intel i7", server.ToString());
        }

        [TestMethod]
        public void Client_PCFactory_ShouldReturnCorrectDefaultSpecifications()
        {
            // Arrange
            IComputerAbstractFactory factory = new PCFactory();

            // Act
            Computer pc = factory.CreateComputer();

            // Assert
            Assert.AreEqual("2GB", pc.GetRAM());
            Assert.AreEqual("500GB", pc.GetHDD());
            Assert.AreEqual("2.4GHz", pc.GetCPU());

            Assert.AreEqual("RAM=2GB, HDD=500GB, CPU=2.4GHz", pc.ToString());
        }
    }
}
