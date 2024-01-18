using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_step
{
   
    class A
    {
        public void sum()
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sum is {0}", x+y);
        }
        public int sum(int x, int y)
        {
            Console.WriteLine("sum is {0}", x + y);
        }
        public void sum(double x, double y)
        {
            Console.WriteLine("sum is {0}", x + y);
        }


        public static void Main()
        {

            A obj = new A();
            Console.WriteLine("enter two numbers");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
           
            obj.sum(x, y);
            Console.WriteLine("enter two double numbers");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            obj.sum(x, y);
            Console.ReadKey();
        }
    }
    
}
