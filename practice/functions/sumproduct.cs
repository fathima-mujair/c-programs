using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_step
{
    class Program
    {
        public int product(int x,int y)
        {
            return (x * y);
        }
        public int sum(int a,int b)
        {
            return a+b;
            
        }

        public static void Main()
        {
            Program obj = new Program();
            int a,b;
            Console.WriteLine("enter the number");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            int s= obj.sum(a,b);
            int p = obj.product(a, b);
            Console.WriteLine("sum is {0} and product is {1}",s,p);
            
            Console.ReadKey();


        }
    }
}
