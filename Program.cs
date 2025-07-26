using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH.Lab2._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Matrix Diagonal Difference ===");

                int n;
                do
                {
                    Console.Write("Enter size of the square matrix (N >= 3): ");
                } while (!int.TryParse(Console.ReadLine(), out n) || n < 3);

                int[,] matrix = new int[n, n];

                Console.WriteLine($"\nEnter {n * n} integers for the {n}x{n} matrix:");

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write($"Element [{i + 1},{j + 1}]: ");
                        while (!int.TryParse(Console.ReadLine(), out matrix[i, j]))
                        {
                            Console.Write("Invalid input. Enter an integer: ");
                        }
                    }
                }

                int leftToRightSum = 0;
                int rightToLeftSum = 0;

                for (int i = 0; i < n; i++)
                {
                    leftToRightSum += matrix[i, i];            
                    rightToLeftSum += matrix[i, n - 1 - i];     
                }

                int difference = Math.Abs(leftToRightSum - rightToLeftSum);

                Console.WriteLine($"\nLeft-to-Right Diagonal Sum : {leftToRightSum}");
                Console.WriteLine($"Right-to-Left Diagonal Sum : {rightToLeftSum}");
                Console.WriteLine($"Absolute Diagonal Difference: {difference}");
            
        }
    }

}
