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
            //1****
            //12***
            //123**
            //1234*
            //12345
            int n;
            Console.WriteLine("Enter the limit");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <=n ; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                for (int k = n-i; k >= 1 ; k--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            
            Console.ReadKey();
        }
    }
}
