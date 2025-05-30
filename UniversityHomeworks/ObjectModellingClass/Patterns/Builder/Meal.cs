namespace UniversityHomeworks.ObjectModellingClass.Patterns.Builder
{
    /// <summary>
    /// Represents a meal composed of multiple items (burgers, drinks).
    /// </summary>
    public class Meal
    {
        private readonly List<IItem> items = new List<IItem>();

        /// <summary>
        /// Adds an item to the meal.
        /// </summary>
        public void AddItem(IItem item) => items.Add(item);

        /// <summary>
        /// Returns the total cost of the meal.
        /// </summary>
        public float GetCost() => items.Sum(item => item.Price());

        /// <summary>
        /// Returns all items in the meal
        /// </summary>
        /// <returns></returns>
        public List<IItem> GetItems()
        {
            return this.items;
        }

        /// <summary>
        /// Displays the items in the meal.
        /// </summary>
        public void ShowItems()
        {
            foreach (IItem item in items)
            {
                Console.WriteLine($"Item: {item.Name()}, Packing: {item.Packing().Pack()}, Price: {item.Price()}");
            }
        }
    }
}
