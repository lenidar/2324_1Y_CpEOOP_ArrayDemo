using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2324_1Y_CpEOOP_ArrayDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = new int[100];
            int dispCount = 0;

            sequence[0] = 0;
            sequence[1] = 1;

            for(int x = 2; x < sequence.Length; x++) 
                sequence[x] = sequence[x - 1] + sequence[x - 2];

            foreach (int s in sequence)
            {
                Console.Write($"{s}\t");
                dispCount++;
                if (dispCount == 10)
                {
                    dispCount = 0;
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
