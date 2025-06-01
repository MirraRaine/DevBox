namespace UniversityHomeworks.ObjectModellingClass.Patterns.Builder2
{
    /// <summary>
    /// The product class representing a computer with optional features.
    /// </summary>
    public class Computer
    {
        public string HDD { get; }
        public string RAM { get; }
        public bool IsGraphicsCardEnabled { get; }
        public bool IsBluetoothEnabled { get; }

        /// <summary>
        /// Constructs a computer object using the builder.
        /// </summary>
        /// <param name="builder">The builder containing configuration.</param>
        public Computer(ComputerBuilder builder)
        {
            HDD = builder.HDD;
            RAM = builder.RAM;
            IsGraphicsCardEnabled = builder.IsGraphicsCardEnabled;
            IsBluetoothEnabled = builder.IsBluetoothEnabled;
        }
    }
}
