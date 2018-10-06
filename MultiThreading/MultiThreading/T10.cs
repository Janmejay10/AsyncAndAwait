using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MultiThreading
{                               //using Name property of Thread class to get the name of the of thread

    public class MyThread7
    {
        public void Thread1()
        {
            Thread t = Thread.CurrentThread;
            Console.WriteLine(t.Name + " is running");
        }
    }
    public class T10
    {
        public static void Main()
        {
            MyThread7 mt = new MyThread7();
            Thread t1 = new Thread(new ThreadStart(mt.Thread1));
            Thread t2 = new Thread(new ThreadStart(mt.Thread1));
            Thread t3 = new Thread(new ThreadStart(mt.Thread1));
            t1.Name = "Jay";
            t2.Name = "Rudransh";
            t3.Name = "Shekhar";
            t1.Start();
            t2.Start();
            t3.Start();
            Console.Read();
        }
    }
}