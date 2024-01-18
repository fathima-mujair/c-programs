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
            int n,i=0;
            
            Console.WriteLine("Enter the limit;");
            n= Convert.ToInt32(Console.ReadLine());
           while(i<=n)
            {
                if(i%2==0)
                Console.WriteLine(i);
                i++;
            }
            Console.ReadKey();
        }
    }
}
