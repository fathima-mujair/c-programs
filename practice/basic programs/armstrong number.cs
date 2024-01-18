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
            int n,rem,r=0,cube,sum=0,p;
            
            Console.WriteLine("Enter a 3 digit number;");
            n= Convert.ToInt32(Console.ReadLine());
            p = n;
            do
            {
                rem = n % 10;
                cube = rem * rem * rem;
                sum = sum + cube;
                n = n / 10;
            }
            while (n > 0);
            if(p==sum)
                Console.WriteLine("number is amstrong");
            else
                Console.WriteLine("not amstrong");
            Console.ReadKey();
        }
    }
}
