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
        public int p1
        {
            set;
            get;
        }

    }
    
    class B
    { 
       
        public static void Main()
        {

            A ob = new A();
            Console.WriteLine("Enter the number");
            ob.p1 = Convert.ToInt32(Console.ReadLine());
            int f = 1;
            if (ob.p1 > 0)
            {
                for (int i = 1; i <= ob.p1; i++)
                {
                    f = f * i;
                }
                Console.WriteLine("factorial is {0}", f);
            }
            else
                Console.WriteLine(" the number is zero");
            Console.ReadKey();
        }
    }
    
}
