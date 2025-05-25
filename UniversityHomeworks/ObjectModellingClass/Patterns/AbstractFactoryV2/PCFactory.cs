namespace UniversityHomeworks.ObjectModellingClass.Patterns.AbstractFactoryV2
{
    public class PCFactory : ComputerAbstractFactory
    {
        private string ram;
        private string hdd;
        private string cpu;

        public PCFactory(string ram, string hdd, string cpu)
        {
            this.ram = ram;
            this.hdd = hdd;
            this.cpu = cpu;
        }
        public Computer CreateComputer()
        {
            return new PC(ram, hdd, cpu);
        }

        public override string ToString()
        {
            return "RAM= " + ram + ", HDD=" + hdd + ", CPU=" + cpu;
        }
    }
}
