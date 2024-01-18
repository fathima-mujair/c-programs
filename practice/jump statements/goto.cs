using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class Employee
    {
        public static void Main()
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());

            switch(n)
            {
                case 1:Console.WriteLine("sunday");
                    break;
                case 2:
                    Console.WriteLine("monday");
                    break;
                case 3:
                    Console.WriteLine("tuesday");
                    goto case 1;
                default:
                    Console.WriteLine("invalid day");
                    break;

            }
            
            
           
            Console.ReadKey();
        }
    }
}
