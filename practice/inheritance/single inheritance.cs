using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_step
{
    class A
    {
        public void displayA()
        {
            Console.WriteLine("Class A");
        }
    }
    class B:A
    {
        public void displayB()
        {
            Console.WriteLine("Class B");
        }
        public static void Main()
        {
            B obj = new B();
            obj.displayA();
            obj.displayB();
            Console.ReadKey();
        }

    }
    
}
