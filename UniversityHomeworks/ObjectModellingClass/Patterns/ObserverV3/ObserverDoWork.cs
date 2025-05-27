namespace UniversityHomeworks.ObjectModellingClass.Patterns.ObserverV3
{
    public class ObserverDoWork : ObserverWorker
    {
        public ObserverDoWork(Context ctx)
        {
            this.ctx = ctx;
            //this.subject.attach(this);
            this.ctx.Attach(this);
        }

        public override void Update()
        {
            Console.WriteLine("ObserverDoWork: " + ctx.GetState().ToUpper()); //throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
        }
    }
}
