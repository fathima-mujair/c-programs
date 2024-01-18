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
            int r1,r2,c1,c2;
            Console.WriteLine("Enter the row limit :");
            r1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the column limit :");
            c1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the row limit :");
            r2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the column limit :");
            c2 = Convert.ToInt32(Console.ReadLine());
            int[,] A = new int[r1,c1];
            int[,] B = new int[r2, c2];
            int[,] C = new int[r1, c1];
            if (r1 == r2 && c1 == c2)
            {
                Console.WriteLine("Enter the elements of first array");
                for (int i = 0; i < r1; i++)
                {
                    for (int j = 0; j < c1; j++)
                        A[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Enter the elements of second array");
                for (int i = 0; i < r2; i++)
                {
                    for (int j = 0; j < c2; j++)
                    {
                        B[i, j] = Convert.ToInt32(Console.ReadLine());
                        C[i, j] = A[i, j] + B[i, j];
                    }

                }
                Console.WriteLine("The resultant matrix is ");
                for (int i = 0; i < r1; i++)
                {
                    for (int j = 0; j < c1; j++)
                        Console.Write(" " + C[i, j]);
                    Console.WriteLine();
                }

            }
            else
            Console.WriteLine("operation is  not possible");
            
           
            Console.ReadKey();
        }
    }
}
