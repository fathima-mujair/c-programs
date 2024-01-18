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
            int n1, n2;
            string s;

            Console.WriteLine("Enter the first number ;");
            n1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number ;");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the operator ;");
            s = (Console.ReadLine());
            if(s=="+")
            Console.WriteLine("the sum is {0}",n1+n2);
            else if(s=="-")
                Console.WriteLine("the difference is {0}", n1 - n2);
            else if(s=="*")
                Console.WriteLine("the product is {0}", n1 * n2);
            else if(s=="/")
                Console.WriteLine("the division is {0}", n1 / n2);
            else
                Console.WriteLine("invalid operator");


            Console.ReadKey();
        }
    }
}
