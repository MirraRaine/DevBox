namespace UniversityHomeworks.ObjectModellingClass.Patterns.Builder2
{
    //Builder Class
    public class ComputerBuilder
    {
        // required parameters
        public string HDD;
        public string RAM;

        // optional parameters
        public bool IsGraphicsCardEnabled;
        public bool IsBluetoothEnabled;

        public ComputerBuilder(string hdd, string ram)
        {
            this.HDD = hdd;
            this.RAM = ram;
        }

        public ComputerBuilder SetGraphicsCardEnabled(bool isGraphicsCardEnabled)
        {
            this.IsGraphicsCardEnabled = isGraphicsCardEnabled;
            return this;
        }

        public ComputerBuilder SetBluetoothEnabled(bool isBluetoothEnabled)
        {
            this.IsBluetoothEnabled = isBluetoothEnabled;
            return this;
        }

        public Comp Build()
        {
            return new Comp(this);
        }
    }
}
