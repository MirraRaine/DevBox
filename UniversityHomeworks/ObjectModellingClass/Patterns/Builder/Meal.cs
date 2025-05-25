namespace UniversityHomeworks.ObjectModellingClass.Patterns.Builder
{
    public class Meal
    {
        private List<IItem> items = new List<IItem>();

        public void AddItem(IItem item)
        {
            items.Add(item);
        }

        public float GetCost()
        {
            float cost = 0.0f;

            foreach (IItem item in this.items)
            {
                cost += item.Price();
            }
            return cost;
        }

        public void ShowItems()
        {

            foreach (IItem item in this.items)
            {
                Console.WriteLine("Item: " + item.Name());
                Console.WriteLine(", Packing : " + item.Packing().Pack());
                Console.WriteLine(", Price : " + item.Price());
            }
        }
    }
}
