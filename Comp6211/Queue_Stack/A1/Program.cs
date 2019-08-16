using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Linq;
using System.Text.RegularExpressions;


namespace A1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> stack = new Stack<char>();

            Console.WriteLine("Enter the word you think is a palindrome: ");
            string input = Console.ReadLine();

            input = input.ToUpper();
            foreach (char x in input)
            {
                stack.Push(x);
            }

            bool Yes = true;
            foreach (char x in input)
            {
                if (x != stack.Pop())
                {
                    Yes = false;
                    break;
                }
            }
            Console.WriteLine($"{input} spelt backwards is, {Yes}, {input} is a palindrome  ");
        }
    }
}
