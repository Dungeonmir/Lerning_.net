using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[10, 10];
            int rows = 10;
            int columns = 10;
            for (int i = 1; i < rows; i++)
            {
                for (int j = 1; j < columns; j++)
                {
                    array[i,j] = i * j;
                    Console.Write($"{array[i,j]} \t");
                }
                Console.WriteLine();
            }
            
        }
    }
}
