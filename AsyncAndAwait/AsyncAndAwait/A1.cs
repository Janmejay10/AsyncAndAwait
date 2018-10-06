using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AsyncAndAwait
{
    class A1
    {
        static void Main(string[] args)
        {
            Method();
            Console.WriteLine("Main Thread");
            Console.Read();
        }

        public static async void Method()
        {
          await Task.Run(new Action(LongTask));
            Console.WriteLine("New Thread"); // means wait until LongTask finishes
        }

        public static void LongTask()
        {
            Thread.Sleep(5000);
        }
    }
    
}
