using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_step
{
    class Program
    {
        public static void Main()
        {
            //           1
            //          1 1
            //         1 2 1   
            //        1 3 3 1
            //       1 4 6 4 1
            int n,c=1;
        
            Console.WriteLine("Enter the limit");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)//space
                    Console.Write(" ");


                for (int k = 0; k <= i; k++)
                {
                    if (k == 0 || i == 0)
                        c = 1;
                    else
                        c = c * (i - k + 1) / k;
                    Console.Write(c+" ");                   
                }
                Console.WriteLine();
            }
           
            Console.ReadKey();
        }
    }
}
