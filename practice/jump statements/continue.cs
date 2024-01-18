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
            int n=5,i=0;
            
            //Console.WriteLine("Enter a 3 digit number;");
            //n= Convert.ToInt32(Console.ReadLine());
            //p = n;
            while(i<=n)
            {
                 i++;
                if ( i== 3)
                        continue;
                Console.WriteLine(i);
               
            }
           
            //if(p==sum)
            //    Console.WriteLine("number is amstrong");
            //else
            //    Console.WriteLine("not amstrong");
            Console.ReadKey();
        }
    }
}
