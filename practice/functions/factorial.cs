using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_step
{
    class Program
    {
        public int factorial(int x)
        {
            int f = 1;
            for (int i = x; i > 0; i--)
                f = f * i;
            return f;
        }
        
        public static void Main()
        {
            Program obj = new Program();
            int n;
            Console.WriteLine("enter the number");
            n = Convert.ToInt32(Console.ReadLine());
           int a= obj.factorial(n);
            Console.WriteLine("factorial of this number is {0}",a);
            
            Console.ReadKey();


        }
    }
}
