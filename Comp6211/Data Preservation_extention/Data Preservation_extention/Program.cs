using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Preservation_extention
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1. Data Source - An array of random ints returned from the DataCreation() Method*/
            int[] dataset = DataCreation();
            Console.WriteLine("************* Complete data set **************");
            foreach (int x in dataset)
                Console.Write("{0}\t", x);

            var greaterthan =
                from number in dataset
                where (number % 2) == 0
                select number;

            // 3. Query execution.
            Console.WriteLine("\n\n\n******** Even Numbers in the data set ********");
            foreach (int x in greaterthan)
            {
                Console.Write("{0}\t ", x);
            }
        }

        /*Generates an array of 10 Random numbers*/
        static int[] DataCreation()
        {
            Random rand = new Random();
            int[] numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = rand.Next(1000, 10000);
            return numbers;
        }
    }
    
}
