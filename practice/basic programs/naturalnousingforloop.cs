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
            int n;
            Console.WriteLine("enter the limit ;");
            n = Convert.ToInt32(Console.ReadLine());

           for(int i=0;i<=n;i++)
            {
                Console.WriteLine(i);
            }
            
            
           
            Console.ReadKey();
        }
    }
}
