//namespace UniversityHomeworks.ObjectModellingClass.Patterns.ObserverV3
//{
//    public class Machine
//    {
//        public bool IsReady { get; private set; } = true;
//        public void DoSomeStuff()
//        {
//            IsReady = false;

//            // Simulate "asyncMethod" work inside the thread
//            Thread t = new Thread(() =>
//            {
//                AsyncMethod(); // Simulating the "run" content
//            });

//            t.Start();
//            t.Join(); // Wait for thread to finish
//        }

//        public void AsyncMethod()
//        {
//            // Simulate heavy work...
//            Thread.Sleep(500); // placeholder for real work

//            // Work is done
//            IsReady = true;
//        }
//    }
//}
