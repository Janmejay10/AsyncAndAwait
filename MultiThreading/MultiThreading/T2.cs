using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreading
{
    class T2
    {
        static void Test1()
        {
            for(int i = 1; i <= 100; i++)
            {
                Console.WriteLine("Test1: " + i);
            }
        }
        static void Test2()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("Test2: " + i);
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
            T2.Test1();  //test1();
            T2.Test2();  //test2();
            T2.Test3();  //test3();
            Console.Read();
        }
    }
}
