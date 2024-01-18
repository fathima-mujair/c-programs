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
            int n,a=0,b=1,c,i=1;
            Console.WriteLine("enter the limit ;");
            n = Convert.ToInt32(Console.ReadLine());
            
            while (i<=n)
            {
                Console.WriteLine(a);
                c = a + b;
                a = b;
                b = c;
                i++;
            }
           



            Console.ReadKey();
        }
    }
}
