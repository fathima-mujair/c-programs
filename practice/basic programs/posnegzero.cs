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

            Console.WriteLine("Enter a number ;");
            n1= Convert.ToInt32(Console.ReadLine());
            if(n1>0)
            Console.WriteLine("the number is positive");
            else if(n1<0)
                Console.WriteLine("the number is negative");
            else if(n1==0)
                Console.WriteLine("number is zero");
           


            Console.ReadKey();
        }
    }
}
