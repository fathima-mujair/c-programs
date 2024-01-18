using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_step
{

    class A
    {
       
        public int p1
        {
            set;
            get;
            
        }
        public int p2
        {
            set;
            get;

        }
    }
    class B
    { 
        public static void Main()
        {

            A obj = new A();
            Console.WriteLine("Enter two numbers");
            obj.p1 = Convert.ToInt32(Console.ReadLine());
            obj.p2= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("the sum is {0}",obj.p1 + obj.p2);
            Console.ReadKey();
        }
    }
    
    
}
