using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Stack_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack s1 = new Stack();

            for(int i = 0; i < 10; i ++)
            {
                Console.Write("Please enter a number: ");
                s1.Push(double.Parse(Console.ReadLine()));
            }

            Console.Write("Please enter a number to search for: ");
            double number = double.Parse(Console.ReadLine());

            if(s1.Contains(number))
            {
                int counter = s1.Count;
                for (int i = 0; i < counter; i++)
                {
                    if (double.Parse(s1.Peek().ToString()) != number)
                    {
                        s1.Pop();
                    }
                    else
                        break;
                }
            }
            else
                Console.Write($"{number} was not found in the collection....");
            foreach(object x in s1)
            {
                Console.Write(x);
            }
        }
    }
}
