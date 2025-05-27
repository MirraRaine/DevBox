namespace UniversityHomeworks.ObjectModellingClass.Patterns.ObserverV3
{
    public class ObserverIsSleeping : ObserverWorker
    {
        public ObserverIsSleeping(Context ctx)
        {
            this.ctx = ctx;
            this.ctx.Attach(this);
        }

        public override void Update()
        {
            Console.WriteLine("ObserverIsSleeping: " + ctx.GetState().ToUpper()); //throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
        }
    }
}
