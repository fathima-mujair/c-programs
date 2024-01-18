using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_step
{

    sealed class S
    {
        
        public void display()
        {
            Console.WriteLine("sealed class method");
        }
    }
    class A
    {

        public static void Main()
        {

            S obj = new S();
            obj.display();
            Console.ReadKey();
        }
    }
    
}
