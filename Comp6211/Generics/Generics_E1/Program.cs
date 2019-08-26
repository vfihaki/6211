using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Generics_E1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Please enter a number: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Please enter a string: ");
            string name = Console.ReadLine();

            if (Comparison<int,string>(num,name))
                Console.WriteLine("They are the same");
            else
                Console.WriteLine("They are different");


        }
        public static bool Comparison<I,S> (I input1, S input2) 
        {
            if (input1.ToString().Equals(input2.ToString()))
                return true;
            else
                return false;
        }
    }
}
