using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Preservation
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            double[] dubs = new double[1000];
            for (int i = 0; i < dubs.Length; i++)
            {

                dubs[i] = Math.Round(rand.NextDouble(), 3);
                Console.Write("{0}\t", dubs[i]);
                Formatting(i);
            }
            double [] dubs = new double[]
        }

        static void Formatting(int i)
        {
            int rowCount = 10;
            if ((i + 1) % rowCount == 0)
                Console.WriteLine();
        }
    }
}
