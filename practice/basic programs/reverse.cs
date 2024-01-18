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
            int n,rem,r=0;
            
            Console.WriteLine("Enter the number;");
            n= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("reverse of the number;");
            while (n>0)
            {
                rem = n % 10;
                r = r * 10 + rem;
                n = n / 10;
            }
            Console.WriteLine(r);
            Console.ReadKey();
        }
    }
}
