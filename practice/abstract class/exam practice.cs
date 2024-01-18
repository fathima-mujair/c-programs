using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_step
{
    class A
    {
        public int x, y;
        public void read()
        {
            Console.WriteLine("enter two numbers");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
        }
    }
    class B : A
    {
        public int s;
        public void sum()
        {
            s = x + y;
            Console.WriteLine("sum is {0}", s);
        }
    }
    class C : B
    {
        public void avg()
        {
            Console.WriteLine("average is {0}", s / 2);
        }
        public static void Main()
        {
            C obj = new C();
            obj.read();
            obj.sum();
            obj.avg();
            Console.ReadKey();
        }
    }

}
