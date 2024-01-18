using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_step
{


    public class gen<X, Y>
    {
        public X a;
        public Y b;
        public gen(X i,Y j)
        {
            a = i;
            b = j;
        }
    }
    class A
    {
        public static void Main()
        {
            int m, n;
            Console.WriteLine("Enter two integer values");
            m = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            gen<int, int> obj = new gen<int, int>(m, n);
            Console.WriteLine("The sum is :{0}", obj.a + obj.b);

            string m1, n1;
            Console.WriteLine("Enter two string ");
            m1 = Console.ReadLine();
            n1 = Console.ReadLine();
            gen<string, string> obj1 = new gen<string, string>(m1, n1);
            Console.WriteLine("The string is :{0}", obj1.a + obj1.b);
            Console.ReadKey();
        }
    }
    
}
