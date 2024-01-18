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

            int n1;
            Console.WriteLine("enter a number;");
            n1 = Convert.ToInt32(Console.ReadLine());
            
            if(n1%2==0)
            {
                Console.WriteLine("{0} is even", n1);
            }
            else
            {
                Console.WriteLine("{0} is odd", n1);
            }

          
            Console.ReadKey();
        }
    }
}
