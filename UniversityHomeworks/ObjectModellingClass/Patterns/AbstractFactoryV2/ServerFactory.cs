namespace UniversityHomeworks.ObjectModellingClass.Patterns.AbstractFactoryV2
{
    /// <summary>
    /// Factory for creating `Server` instances using specified configuration values.
    /// </summary>
    public class ServerFactory : IComputerAbstractFactory
    {
        private string ram;
        private string hdd;
        private string cpu;

        /// <summary>
        /// Initializes the factory with hardware specifications for a server.
        /// </summary>
        public ServerFactory(string ram, string hdd, string cpu)
        {
            this.ram = ram;
            this.hdd = hdd;
            this.cpu = cpu;
        }

        /// <summary>
        /// Initializes the factory with the default hardware specifications for a server.
        /// </summary>
        public ServerFactory()
        {
            this.ram = "8GB";
            this.hdd = "256GB";
            this.cpu = "Intel i7";
        }

        public Computer CreateComputer()
        {
            return new Server(ram, hdd, cpu);
        }

        public override string ToString()
        {
            return "RAM=" + ram + ", HDD=" + hdd + ", CPU=" + cpu;
        }
    }
}
