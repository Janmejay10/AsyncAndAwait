using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MultiThreading
{
    class MyThread2    // Threading With non-static-method
    {
        public  void Thread2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.Read();
        }
    }

    class T5
    {
        static void Main(string[] args)
        {
            MyThread2 mt = new MyThread2();
            Thread t1 = new Thread(new ThreadStart(mt.Thread2));
            Thread t2 = new Thread(new ThreadStart(mt.Thread2));
            t1.Start();
            t2.Start();
            Console.Read();
            
        }
    }
}
