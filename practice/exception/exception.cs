using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_step
{

   
    class A
    { 
        public static void Main()
        {
            try
            {
                int x,y, z;
                A obj = new A();
                Console.WriteLine("Enter the numbers");
                x = Convert.ToInt32(Console.ReadLine());
                y = Convert.ToInt32(Console.ReadLine());
                z = x/y;
                Console.WriteLine("the  output is {0}", z);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            //catch(DivideByZeroException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch(FormatException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch(OverflowException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            finally
            {
                Console.WriteLine("finally .....always running");
            }
            Console.ReadKey();
        }
    }
    
    
}
