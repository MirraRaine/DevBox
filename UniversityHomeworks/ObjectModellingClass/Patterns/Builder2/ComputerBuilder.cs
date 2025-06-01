namespace UniversityHomeworks.ObjectModellingClass.Patterns.Builder2
{
    /// <summary>
    /// Builder class for constructing a <see cref="Computer"/> object step-by-step.
    /// </summary>
    public class ComputerBuilder
    {
        // Required parameters
        public string HDD { get; }
        public string RAM { get; }

        // Optional parameters
        public bool IsGraphicsCardEnabled { get; private set; }
        public bool IsBluetoothEnabled { get; private set; }

        /// <summary>
        /// Initializes a builder with required HDD and RAM values.
        /// </summary>
        public ComputerBuilder(string hdd, string ram)
        {
            HDD = hdd;
            RAM = ram;
        }

        /// <summary>
        /// Enables or disables the graphics card.
        /// </summary>
        public ComputerBuilder SetGraphicsCardEnabled(bool enabled)
        {
            IsGraphicsCardEnabled = enabled;
            return this;
        }

        /// <summary>
        /// Enables or disables Bluetooth.
        /// </summary>
        public ComputerBuilder SetBluetoothEnabled(bool enabled)
        {
            IsBluetoothEnabled = enabled;
            return this;
        }

        /// <summary>
        /// Builds and returns the configured <see cref="Computer"/> object.
        /// </summary>
        public Computer Build()
        {
            return new Computer(this);
        }
    }
}
