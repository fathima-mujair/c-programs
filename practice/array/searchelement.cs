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
            int n,a,f=0,position=0;
            Console.WriteLine("Enter the limit :");
            n = Convert.ToInt32(Console.ReadLine());
            int[] ar = new int[n];
            Console.WriteLine("Enter the array elements :");
            for(int i=0;i<n;i++)
            {
               ar[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Ente the element to search :");
            a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if (ar[i] == a)
                {
                    f++;
                    position = i;
                }
            }
            if(f>0)
                Console.WriteLine("the element is found at position {0}",position);
            else
                Console.WriteLine("the element is  not found ");
            Console.ReadKey();
        }
    }
}
