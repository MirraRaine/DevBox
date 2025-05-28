namespace UniversityHomeworks.ObjectModellingClass.Patterns.AbstractFactoryV2
{
    /// <summary>
    /// Factory for creating `PC` instances using specified configuration values.
    /// </summary>
    public class PCFactory : IComputerAbstractFactory
    {
        private readonly string ram;
        private readonly string hdd;
        private readonly string cpu;

        /// <summary>
        /// Initializes the factory with hardware specifications for a PC.
        /// </summary>
        public PCFactory(string ram, string hdd, string cpu)
        {
            this.ram = ram;
            this.hdd = hdd;
            this.cpu = cpu;
        }

        /// <summary>
        /// Initializes the factory with default hardware specifications for a PC.
        /// </summary>
        public PCFactory()
        {
            this.ram = "2GB";
            this.hdd = "500GB";
            this.cpu = "2.4GHz";
        }

        /// <inheritdoc/>
        public Computer CreateComputer()
        {
            return new PC(ram, hdd, cpu);
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return "RAM=" + ram + ", HDD=" + hdd + ", CPU=" + cpu;
        }
    }
}
