using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Queue_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q1 = new Queue();
            /*
            while(true)
            {
                Console.Write("Please enter a name to add to the queue: ");
                q1.Enqueue(Console.ReadLine());
                Console.Write("Would you like add another name (y/n): ");
                if (Console.ReadLine().ToLower() == "n")
                {
                    break;
                }
                int counter = q1.Count;
                for(int i = 0; i < counter; i++)
                {
                    Console.WriteLine($"Name: {q1.Dequeue()}");
                }
            }*/
            while(true)
            { 
                Console.Write("Please enter a name: ");
                q1.Enqueue(Console.ReadLine());
                Console.Write("Would you like add another name (y/n): ");
                if (Console.ReadLine().ToLower() == "n")
                {
                    break;
                }
            }
            Console.Clear();
            Console.Write("Please enter a name to search for: ");
            string name = Console.ReadLine();

            if (q1.Contains(name))
            {
                int counter = q1.Count;
                for (int i = 0; i < counter; i++)
                {
                    if ((q1.Dequeue().ToString())!= name)
                    {
                        Console.WriteLine($"{name} was found in the collection");
                    }
                    else
                        break;
                }
            }
            else
                Console.Write($"{name} was not found in the collection....\n");
            foreach (object x in q1)
            {
                Console.WriteLine($"{x}");
            }
           
        }
    }
}
