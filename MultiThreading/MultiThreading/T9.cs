using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MultiThreading
{
    public class MyThread6
    {
        public void Thread1()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(200);
            }
        }
    }
    public class T9
    {
        public static void Main()
        {
            MyThread6 mt = new MyThread6();
            Thread t1 = new Thread(new ThreadStart(mt.Thread1));
            Thread t2 = new Thread(new ThreadStart(mt.Thread1));
            Thread t3 = new Thread(new ThreadStart(mt.Thread1));
            t1.Start();
            t1.Join();
            t2.Start();
            t3.Start();
            Console.Read();

          /*  It causes all the calling threads to wait until the current thread(joined thread) 
           *  is terminated or completes its task.
           *  */
        }
    }
}
