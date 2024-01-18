using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_step
{

    abstract class ABS
    {
        
        public abstract void reverse();
    }
    class B:ABS
    {

        public override void reverse()
        {
            int r = 0;
            Console.WriteLine("Enter the number");
            int x = Convert.ToInt32(Console.ReadLine());
            while (x > 0)
            {
                r = r * 10 + x % 10;
                x = x / 10;
            }
            Console.WriteLine("reverse is {0}", r);

        }
        public static void Main()
        {

            B obj = new B();
            obj.reverse();
           
            
            Console.ReadKey();
        }
    }
    
}
