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
            int n,f=1;
            Console.WriteLine("enter the limit ;");
            n = Convert.ToInt32(Console.ReadLine());

           for(int i=1;i<=n;i++)
            {
                f = f * i;
            }
            Console.WriteLine(f);



            Console.ReadKey();
        }
    }
}
