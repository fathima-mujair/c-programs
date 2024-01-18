using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace first_step
{
    abstract class A
    {
        public abstract void Secondlargest(int[] x);

    }
    class B : A
    {
        public override void Secondlargest(int[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                for (int j = i + 1; j < x.Length; j++)
                {
                    if (x[i] < x[j])
                    {
                        int t = x[j];
                        x[j] = x[i];
                        x[i] = t;
                    }
                }
            }
            Console.WriteLine(" second largest number is {0}", x[1]);
        }

        public static void Main()
        {
            int n;
            B obj = new B();
            Console.WriteLine("Enter th limits of array");
            n = Convert.ToInt32(Console.ReadLine());
            int[] num = new int[n];
            Console.WriteLine("Enter the numbers");
            for (int i = 0; i < n; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            obj.Secondlargest(num);

            Console.ReadKey();
        }

    }




}
