using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MultiThreading
{
    class MyThread    // Threading With static-method
    {
        public static void Thread1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }

    class T4
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(MyThread.Thread1));
            Thread t2 = new Thread(new ThreadStart(MyThread.Thread1));

            t1.Start();
            t2.Start();
            Console.WriteLine();
            /*To call the static and non-static methods, 
            you need to pass method name in the constructor of ThreadStart class.
            For static method, we don't need to create the instance of the class. 
            You can refer it by the name of class.
            */
        }
    }
}
