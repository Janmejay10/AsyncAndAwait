using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAndAwait
{
    //   Method1 and Method2 are not dependent on each other and we are calling from the Main method.
    //   we can clearly see Method1 and Method2 are not waiting for each other.
    class A2
    {
       
        public static async Task Method1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine(" Method 1");
                }
            });
        }


        public static void Method2()
        {
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine(" Method 2");
            }
        }

        static void Main(string[] args)
        {
            Method1();
            Method2();
            Console.Read();
        }
    }
}
