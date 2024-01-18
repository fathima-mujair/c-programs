using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_step
{
    class Program
    {
        public void display(params int[]a)
        {
            Console.WriteLine("array elements using for");//i=index
            for (int i = 0; i < a.Length; i++)
                Console.WriteLine(a[i]);
            Console.WriteLine("array elements using foreach");//j is value
            foreach (int j in a)
                Console.WriteLine(j);
        }
        public static void Main()
        {
            Program obj = new Program();
            int n;
            Console.WriteLine("enter the arraylist");
            n = Convert.ToInt32(Console.ReadLine());
            int[] a= new int[n];
            Console.WriteLine("enter the array elements");
            for(int i=0;i<n;i++)
            {
                a[i]= Convert.ToInt32(Console.ReadLine());
            }
            
            obj.display(a);
            Console.ReadKey();
        }
    }
}
