
namespace UniversityHomeworks.ObjectModellingClass.Patterns.AbstractFactoryV2
{
    /// <summary>
    /// Concrete implementation of the `Computer` class representing a personal computer.
    /// </summary>
    public class PC : Computer
    {
        private readonly string ram;
        private readonly string hdd;
        private readonly string cpu;

        /// <summary>
        /// 
        /// Initializes a new instance of `PC` with specified hardware specs.
        /// </summary>
        public PC(string ram, string hdd, string cpu)
        {
            this.ram = ram;
            this.hdd = hdd;
            this.cpu = cpu;
        }

        /// <inheritdoc/>
        public override string GetRAM()
        {
            return this.ram;
        }

        /// <inheritdoc/>
        public override string GetHDD()
        {
            return this.hdd;
        }

        /// <inheritdoc/>
        public override string GetCPU()
        {
            return this.cpu;
        }

        public override string ToString()
        {
            return "RAM=" + this.GetRAM() + ", HDD=" + this.GetHDD() + ", CPU=" + this.GetCPU();
        }
    }
}
