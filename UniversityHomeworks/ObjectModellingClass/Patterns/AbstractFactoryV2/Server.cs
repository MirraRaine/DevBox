namespace UniversityHomeworks.ObjectModellingClass.Patterns.AbstractFactoryV2
{
    public class Server : Computer
    {
        private string ram;
        private string hdd;
        private string cpu;

        public Server(string ram, string hdd, string cpu)
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

        public override string ToString()
        {
            return "RAM= " + this.GetRAM() + ", HDD=" + this.GetHDD() + ", CPU=" + this.GetCPU();
        }
    }
}
