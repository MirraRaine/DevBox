namespace UniversityHomeworks.ObjectModellingClass.Patterns.Builder3
{
    public class Pizza
    {
        private string dough = "";
        private string sauce = "";
        private string topping = "";

        public void SetDough(string dough) { this.dough = dough; }
        public void SetSauce(string sauce) { this.sauce = sauce; }
        public void SetTopping(string topping) { this.topping = topping; }
    }
}
