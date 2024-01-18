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
        public int num
        {
            set;
            get;
        }

    }

    class B
    {

        public static void Main()
        {

            A fact = new A();
            Console.WriteLine("Enter the number");
            fact.num = Convert.ToInt32(Console.ReadLine());
            int f = 1;
            
                for (int i = 1; i <= fact.num; i++)
                    f = f * i;
       
                Console.WriteLine("factorial is {0}", f);
            Console.ReadKey();
        }
    }

}
