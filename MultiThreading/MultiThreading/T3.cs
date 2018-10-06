using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MultiThreading
{
    class T3
    {
        static void Test1()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("Test1: " + i);
            }
        }
        static void Test2()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("Test2: " + i);
                if (i == 50)
                    Thread.Sleep(5000);
 //waiting for 5 seconds and not going to test3 until it finishes
 // the current execution because of having one one thread and that will 
 // execute every logic one by one
            }
        }
        static void Test3()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("Test3: " + i);
            }
        }
        static void Main()
        {
            Test1();
            Test2();
            Test3();
            Console.Read();
        }
    }
}
