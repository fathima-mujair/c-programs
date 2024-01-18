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
                check(-2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally
            {
                Console.WriteLine("finally .....always running");
            }
            Console.ReadKey();
        }
            public static void check(int age)
            {
                if (age < 0)
                    throw new ArgumentOutOfRangeException("Age cannot be negative");
            }
            
        }
    
    
    
}
