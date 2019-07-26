using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question 4");
            Console.Write("Input first number: ");
            int fnumber = int.Parse(Console.ReadLine());
            Console.Write("Input second number: ");
            int snumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"{fnumber} x {snumber} = {fnumber * snumber}");
            Console.ReadLine();
        }
    }
}
