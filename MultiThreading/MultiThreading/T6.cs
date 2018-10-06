using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MultiThreading
{
    class MyThread3    // executing different methods on each thread
    {
        public static void Thread3()
        {
            Console.WriteLine("task one");
        }
        public static void Thread4()
        {
            Console.WriteLine("task two");
        }
    }
    public class T6
    {
        public static void Main()
        {
            Thread t1 = new Thread(new ThreadStart(MyThread3.Thread3));
            Thread t2 = new Thread(new ThreadStart(MyThread3.Thread4));
            t1.Start();
            t2.Start();
            Console.Read();
        }
    }
}