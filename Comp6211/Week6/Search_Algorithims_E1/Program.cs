using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_Algorithims_E1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Q1
            int[] arr = Data();
            foreach (int x in arr)
                Console.Write($"{x}\t");
            //Q2
            Console.Write("\n\nPlease enter a number to search for: ");
            int input = int.Parse(Console.ReadLine());

            if (Find1(arr, input))
                Console.WriteLine("\nWe have found the number " + input + " in the collection...");
            else
                Console.WriteLine("\nWe could not find the number " + input + " in the collection...");
            //Q3
            Console.Write("\n\nPlease enter a number to search for: ");
            int input1 = int.Parse(Console.ReadLine());
            if (Find2(arr, input1))
                Console.WriteLine("\nWe have found the number " + input1 + " in the collection...");
            else
                Console.WriteLine("\nWe could not find the number " + input1 + " in the collection...");
            Console.ReadLine();
        }
        static int[] Data()
        {
            Random rand = new Random();
            int[] nums = new int[100000];
            for (int i = 0; i < nums.Length; i++)
                nums[i] = rand.Next(100,999);
            return nums;
        }
        static bool Find1(int[] arr, int val)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Equals(val))
                    return true;
            }
            return false;
        }
        static bool Find2(int[] arr, int val)
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
    }
}
