using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class Employee
    {
        public static void Main()
        {
            int a,b,c;
            
            Console.WriteLine("Enter three numbers ;");
            a= Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());

            if (a>b)
            {
                if(a>c)
                    Console.WriteLine("{0} is greater",a);
                else
                    Console.WriteLine("{0} is greater", c);

            }
            elseif (b > c)
                Console.WriteLine("{0} is greater", b);
            else
                Console.WriteLine("{0} is greater", c);
            Console.ReadKey();
        }
    }
}
