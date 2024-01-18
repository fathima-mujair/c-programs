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
            int n,sum=0;
            Console.WriteLine("Enter the limit :");
            n = Convert.ToInt32(Console.ReadLine());
            int[] ar = new int[n];
            Console.WriteLine("Enter the array elements :");
            for(int i=0;i<n;i++)
            {
               ar[i] = Convert.ToInt32(Console.ReadLine());
                sum = sum + ar[i];
            }
            Console.WriteLine("Thesum of array elements is {0}",sum);
            
            Console.ReadKey();
        }
    }
}
