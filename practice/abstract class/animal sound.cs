using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace first_step
{
    abstract class Animal
    {
        public abstract void sound();
        public void sleep()
        {
            Console.WriteLine("the sound of sleep is zzz");
        }
    }
    class Pig : Animal
    {
        public override void sound()
        {
            Console.WriteLine("the sound of pig is oing oing");
        }
        public static void Main()
        {
            Pig obj = new Pig();
            obj.sleep();
            obj.sound();
            Console.ReadKey();
        }
       
    }
    
        

    
 }
