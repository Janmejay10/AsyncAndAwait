using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MultiThreading
{
    /* The Abort() method is used to terminate the thread.
     * It raises ThreadAbortException if Abort operation is not done.
     * */

    public class MyThread5
    {
        public void Thread1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(200);
            }
        }
    }
    public class T8
    {
        public static void Main()
        {
            Console.WriteLine("entry point");
            MyThread5 mt = new MyThread5();
            Thread t1 = new Thread(new ThreadStart(mt.Thread1));
            Thread t2 = new Thread(new ThreadStart(mt.Thread1));

            t1.Start();
            t2.Start();
            try
            {
                t1.Abort();
                t2.Abort();
            }
            catch (ThreadAbortException tae)
            {
                Console.WriteLine(tae.ToString());
            }
            Console.WriteLine("End of Main");
            Console.Read();
        }
    }
}
