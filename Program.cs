using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_step
{
    class Program
    {
        public static void Main()
        {
            string s;
            Console.WriteLine("Enter the string");
            s = Console.ReadLine();
            int l = s.Length;
            string s1 = "";
            for(int i=l-1;i>=0;i--)
            {
                s1 = s1 + s[i];
            }
            Console.Write("Reverse of this string is {0}", s1);
            Console.ReadKey();
        }
    }
}
