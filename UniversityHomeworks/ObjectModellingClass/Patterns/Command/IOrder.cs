namespace UniversityHomeworks.ObjectModellingClass.Patterns.Command
{
    /// <summary>
    /// Command interface declaring the Execute operation.
    /// </summary>
    public interface IOrder
    {
        /// <summary>
        /// Executes the command.
        /// </summary>
        void Execute();
    }
}
