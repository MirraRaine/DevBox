namespace UniversityHomeworks.ObjectModellingClass.Patterns.Builder2
{
    public class Comp
    {
        public Comp(ComputerBuilder builder)
        {
            this.HDD = builder.HDD;
            this.RAM = builder.RAM;
            this.isGraphicsCardEnabled = builder.IsGraphicsCardEnabled;
            this.isBluetoothEnabled = builder.IsBluetoothEnabled;
        }

        //required parameters
        private string HDD;
        private string RAM;

        //optional parameters
        private bool isGraphicsCardEnabled;
        private bool isBluetoothEnabled;

        public string GetHDD()
        {
            return HDD;
        }

        public string GetRAM()
        {
            return RAM;
        }

        public bool IsGraphicsCardEnabled()
        {
            return isGraphicsCardEnabled;
        }

        public bool IsBluetoothEnabled()
        {
            return isBluetoothEnabled;
        }
    }
}
