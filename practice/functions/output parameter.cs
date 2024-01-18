using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_step
{
    class Program
    {
        public int display(int a, out int b)
        {
            a = a + 10;
            b = a + 10;
            return a;
        }
        public static void Main()
        {
            Program obj = new Program();
            int a=10,b,c;
           c=obj.display(a,out b);
            Console.WriteLine("a ={0} and b={1}", c, b);
            Console.ReadKey();
        }
    }
}
