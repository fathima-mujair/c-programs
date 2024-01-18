using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_step
{
    interface A
    {
        void sum(int x, int y);
    }
    class B
    { 
        public int product()
        {
            Console.WriteLine("enter two numbers");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            return x * y;
        }

    }
    class C : B,A
    {
        public void sum(int x,int y)
        {
            Console.WriteLine("sum is {0}", x+y);
        }
        
        public static void Main()
        {

            C obj = new C();
            Console.WriteLine("enter two numbers");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            obj.sum(x,y);
            int a=obj.product();
            Console.WriteLine("product is {0}", a);
            Console.ReadKey();
        }
    }
    
}
