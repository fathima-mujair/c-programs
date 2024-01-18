using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_step
{
    class A
    {
        public int x,y;
        public void read()
        {
            Console.WriteLine("enter two numbers");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
        }
    }
    class B:A
    {
     
        public void sum()
        {
            int s = x + y;
            Console.WriteLine("sum is {0}",s);
        }
    }
    class C : A
    {
        public void mul()
        {
            int m = x * y;
            Console.WriteLine("product is {0}", m);
        }
    }
        class D : A
        {
            public void avg()
            {
                int avg = (x + y) / 2;
                Console.WriteLine("average is {0}", avg);
            }
            public static void Main()
            {
                
                B obj1 = new B();
                C obj2 = new C();
                D obj3 = new D();
               
                obj1.read();
                obj1.sum();
                obj2.read();
                obj2.mul();
                obj3.read();
                obj3.avg();
                Console.ReadKey();
            }
        }
    
}
