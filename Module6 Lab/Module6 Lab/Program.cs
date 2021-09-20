using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] nums =
                    {
                        {2, 4, 5},
                        {6, 1, 0},
                        {9, 11, 6},
                        {12, 5, 13}
                    };

            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write($"{nums[row,col]}\t");
                }
                Console.WriteLine();
            }
                Console.Read();
        }
    }
}
