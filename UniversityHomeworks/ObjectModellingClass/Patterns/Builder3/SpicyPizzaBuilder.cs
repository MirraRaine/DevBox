namespace UniversityHomeworks.ObjectModellingClass.Patterns.Builder3
{
    public class SpicyPizzaBuilder : PizzaBuilder
    {
        public override void BuildDough()
        {
            pizza.SetDough("pan baked");
            //throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
        }

        public override void BuildSauce()
        {
            pizza.SetSauce("hot");
            // throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
        }

        public override void BuildTopping()
        {
            pizza.SetTopping("pepperoni+salami");
            //throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
        }

        //    public void buildDough()   { pizza.setDough("pan baked"); }
        //    public void buildSauce()   { pizza.setSauce("hot"); }
        //    public void buildTopping() { pizza.setTopping("pepperoni+salami"); }
    }
}
