namespace UniversityHomeworks.ObjectModellingClass.Patterns.FactoryV2
{
    public class PC : Computer
    {
        private string ram;
        private string hdd;
        private string cpu;

        public PC(string ram, string hdd, string cpu)
        {
            this.ram = ram;
            this.hdd = hdd;
            this.cpu = cpu;
        }
        public override string GetRAM()
        {
            return this.ram;
        }

        public override string GetHDD()
        {
            return this.hdd;
        }

        public override string GetCPU()
        {
            return this.cpu;
        }
    }
}
