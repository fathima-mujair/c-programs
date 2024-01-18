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
            int n;
            Console.WriteLine("Enter the limit :");
            n = Convert.ToInt32(Console.ReadLine());
            int[] ar = new int[n];
            Console.WriteLine("Enter the array elements :");
            for(int i=0;i<n;i++)
            {
               ar[i] = Convert.ToInt32(Console.ReadLine());
            }
           
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (ar[i] < ar[j])
                    {

                        ar[i] = ar[i] + ar[j];
                        ar[j] = ar[i] - ar[j];
                        ar[i] = ar[i] - ar[j];
                    }
                }
            }
            Console.WriteLine("The sorted element are ");
            for (int i = 0; i < n; i++)
                Console.WriteLine(ar[i]);
            Console.ReadKey();
        }
    }
}
