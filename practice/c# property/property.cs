using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_step
{

    class A
    {
        private int x;
        public int p1
        {
            set
            {
                x = value;
            }
            get
            {
                return x;
            }
        }
    }
    class B
    { 
        public static void Main()
        {

            A obj = new A();
            Console.WriteLine("Enter two numbers");
            obj.p1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("the number is {0}", obj.p1);
            Console.ReadKey();
        }
    }
    
    
}
