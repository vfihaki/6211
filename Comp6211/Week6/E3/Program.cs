using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3
{
    class Program
    {
        /*Method to find if a value is contained in a collection using a binary searching algorithm*/
        static bool Find(int[] arr, int val)
        {
            int upper, mid, lower;
            upper = arr.Length;
            lower = 0;
            while (lower <= upper)
            {
                mid = lower + (upper - lower) / 2;
                if (arr[mid] == val)
                    return true;
                else if (val < arr[mid])
                    upper = mid - 1;
                else
                    lower = mid + 1;
            }
            return false;
        }
        static void Main(string[] args)
        {
            int[] nums = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            foreach (int x in nums)
                Console.Write(x + " ");

            Console.Write("\n\nPlease enter a number to search for: ");
            int input = int.Parse(Console.ReadLine());

            /*Search for the number and give a response*/
            if (Find(nums, input))
                Console.WriteLine("\nWe have found the number " + input + " in the collection...");
            else
                Console.WriteLine("\nWe could not find the number " + input + " in the collection...")
        }
    }
}
