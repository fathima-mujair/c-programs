using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace first_step
{
    public static class A
    {
        public static int max(int[] arrnum)
        {
            int max = 0;
            for (int i = 0; i < arrnum.Length; i++)
            {
                if (arrnum[i] > max)
                    max = arrnum[i];
            }
            return max;
        }
        public static int min(int[] arrnum)
        {
            int min = arrnum[0];
            for (int i = 0; i < arrnum.Length; i++)
            {
                if (arrnum[i] < min)
                    min = arrnum[i];
            }
            return min;
        }
    }
    class B
    { 
        public static void Main()
        {
            int[] nums = new int[] { 12, 45, 3, 2, 46, 75, 10, 66, 55 };
            //call static method directly using classname.method
            int maxnum = A.max(nums);
            int minnum = A.min(nums);
            Console.WriteLine("maximum number is {0}", maxnum);
            Console.WriteLine("minimum number is {0}", minnum);
            Console.ReadKey();


        }
    }
    
}
