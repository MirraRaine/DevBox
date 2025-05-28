namespace UniversityHomeworks.ObjectModellingClass.Patterns.AbstractFactoryV2
{
    /// <summary>
    /// Defines the abstract base class for different types of computers.
    /// Declares common behavior for retrieving hardware specifications.
    /// </summary>
    public abstract class Computer
    {
        /// <summary>
        /// Returns the RAM specification of the computer.
        /// </summary>
        public abstract string GetRAM();

        /// <summary>
        /// Returns the HDD specification of the computer.
        /// </summary>
        /// <returns></returns>
        public abstract string GetHDD();

        /// <summary>
        /// Returns the CPU specification of the computer.
        /// </summary>
        public abstract string GetCPU();

        /// <summary>
        /// Returns a formatted string with RAM, HDD, and CPU information.
        /// </summary>
        public override string ToString()
        {
            return "RAM=" + this.GetRAM() + ", HDD=" + this.GetHDD() + ", CPU=" + this.GetCPU();
        }
    }
}
