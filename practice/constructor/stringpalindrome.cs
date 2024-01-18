using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace first_step
{
    
    class B
    { 
        public B(string s)
        {
            string s1 = "";
            int len = s.Length;
            for(int i=len-1;i>=0;i--)
            {
                s1 = s1 + s[i];
            }
            if (s1 == s)
                Console.WriteLine("the given string is palindrome");
            else
                Console.WriteLine("The given string is not palindrome");
        }
        public static void Main()
        {
            string s;
            Console.WriteLine("Enter the string");
            s = Console.ReadLine();
            B obj = new B(s);
            Console.ReadKey();
        }
    }
    
}
