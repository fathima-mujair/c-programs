using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_step
{


    abstract class ABS
    {
        public virtual void display()
        {
            Console.WriteLine("Base class method");

        }
        public abstract void absmethod();
    }
    class B:ABS
    {

        public override void absmethod()
        {
            Console.WriteLine("Abstract method");

        }
        public static void Main()
        {

            B obj = new B();
            obj.display();
            obj.absmethod();
            
            Console.ReadKey();
        }
    }
    
}
