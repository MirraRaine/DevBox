namespace UniversityHomeworks.ObjectModellingClass.Patterns.ObserverV3
{
    public class ObserverIsReady : ObserverWorker
    {
        public ObserverIsReady(Context ctx)
        {
            this.ctx = ctx;
            this.ctx.Attach(this);
        }

        public override void Update()
        {
            Console.WriteLine("ObserverIsReady: " + ctx.GetState().ToUpper()); //throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
        }
    }
}
