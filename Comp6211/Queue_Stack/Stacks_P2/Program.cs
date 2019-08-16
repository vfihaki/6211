using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Stacks_P2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack s1 = new Stack();

            Console.WriteLine("How many whole number would you like to use: ");
            if(int.TryParse(Console.ReadLine(), out int result))
            {
                for(int i = 0; i < result; i ++)
                {
                    Console.WriteLine($"Please enter number {i+1}: ");
                    s1.Push(int.Parse(Console.ReadLine()));
                }
            }
            int end = s1.Count;
            Console.Write($"Input in reverse order: ");
            for(int i = 0; i < end; i ++)
            {
                Console.WriteLine($"{ s1.Pop()}");
                Console.WriteLine( );
            }
           //string input = Console.ReadLine();
           //Char[] chars = input.ToCharArray();
           //foreach(char x in chars)
           //{
           //
           //}

        }
    }
}
