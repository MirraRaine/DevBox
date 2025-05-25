namespace UniversityHomeworks.ObjectModellingClass.Patterns.Builder3
{
    public abstract class PizzaBuilder
    {
        protected Pizza pizza;
        public Pizza GetPizza() { return pizza; }
        public void CreateNewPizzaProduct() { pizza = new Pizza(); }
        public abstract void BuildDough();
        public abstract void BuildSauce();
        public abstract void BuildTopping();
    }
}
