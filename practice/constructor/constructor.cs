using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_step
{

    class A
    {
        
        public A()
        {
            Console.WriteLine("Default constructor");
        }
        public A(int x,int y)
        {
            Console.WriteLine("sum is {0}",x+y);
        }
        static A()// access modifier and parameters not allowed
        {
            Console.WriteLine("static constroctor");
        }
        public static void Main()
        {

            A obj = new A();
            A ob1 = new A(2,3);
            
            Console.ReadKey();
        }
    }
    
    
}
