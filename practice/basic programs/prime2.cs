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
            int n,i,p=0;
            Console.WriteLine("enter the limit ;");
            n = Convert.ToInt32(Console.ReadLine());

            for (int j = 2; j <= n; j++)
            {
                for (i = 1; i <= j; i++)
                {
                    if (j % i == 0)
                        p++;

                }
                if (p == 2)
                    Console.WriteLine(j);
            }   
           



            Console.ReadKey();
        }
    }
}
