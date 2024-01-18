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
            int n,rem,r=0,p;
            
            Console.WriteLine("Enter the number;");
            n= Convert.ToInt32(Console.ReadLine());
            p = n;
            
            while (n>0)
            {
                rem = n % 10;
                r = r * 10 + rem;
                n = n / 10;
            }
            if(p==r)
                Console.WriteLine("number is palindrome");
            else
                Console.WriteLine("number is not palindrome");
            Console.ReadKey();
        }
    }
}
