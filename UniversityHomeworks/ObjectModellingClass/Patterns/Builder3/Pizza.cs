namespace UniversityHomeworks.ObjectModellingClass.Patterns.Builder3
{
    /// <summary>
    /// The product class representing a Pizza.
    /// </summary>
    public class Pizza
    {
        private string dough = string.Empty;
        private string sauce = string.Empty;
        private string topping = string.Empty;

        /// <summary>
        /// Sets the type of dough for the pizza.
        /// </summary>
        public void SetDough(string dough) => this.dough = dough;

        /// <summary>
        /// Sets the sauce of the pizza.
        /// </summary>
        public void SetSauce(string sauce) => this.sauce = sauce;

        /// <summary>
        /// Sets the topping for the pizza.
        /// </summary>
        public void SetTopping(string topping) => this.topping = topping;

        /// <summary>
        /// Returns a string representation of the pizza configuration.
        /// </summary>
        public override string ToString()
        {
            return $"Pizza with {dough} dough, {sauce} sauce, and {topping} topping(s).";
        }
    }
}
