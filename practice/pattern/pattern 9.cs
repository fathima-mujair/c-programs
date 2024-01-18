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
            //     *
            //    ***
            //   *****
            //  *******
            // *********
            int n;
            Console.WriteLine("Enter the limit");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <=n ; i++)
            {
                for (int j = 1; j <= n-i; j++)//space
                {
                    Console.Write(" ");
                }
                
                for (int k = 1; k <= i; k++)
                {
                   
                    Console.Write("*");
                   
                }
               
                for (int s = i-1; s >=1; s--)//space
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            
            Console.ReadKey();
        }
    }
}
