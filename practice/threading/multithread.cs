using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace first_step
{
    class A
    {
        public static void Main()
        {
            Thread ob1 = new Thread(new ThreadStart(run1));
            Thread ob2 = new Thread(new ThreadStart(run2));
            ob1.Start();
            ob2.Start();
            Console.ReadKey();
        }
        public static void run1()
        {
            for(int i=0;i<10;i++)
            {
                Console.WriteLine("thread1 is {0}", i);
                Thread.Sleep(1000);
            }
        }
        public static void run2()
        {
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine("thread2 is {0}", i);
                Thread.Sleep(1000);
            }
        }
    }
    
}
