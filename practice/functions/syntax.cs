using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_step
{
    class Program
    {
        public void display()
        {
            Console.WriteLine("normal function");
        }
        public static void static_function()
        {
            Console.WriteLine("static function");
        }
        public  int sum()
        {
           int x = 10, y = 20;
            return x + y;
        }
        public void product()
        {
            int a = 10, b = 30;
            Console.WriteLine("the product is {0}", a*b);
        }
        public static void Main()
        {
            Program obj = new Program();
            obj.display();
            static_function();
            int a = obj.sum();
            Console.WriteLine(a);
            obj.product();
            Console.ReadKey();


        }
    }
}
