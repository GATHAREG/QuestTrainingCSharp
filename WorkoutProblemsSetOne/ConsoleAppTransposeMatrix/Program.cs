using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTransposeMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the number of rows of matrix:");
                int row = int.Parse(Console.ReadLine());
                Console.Write("Enter the number of columns of matrix:");
                int column = int.Parse(Console.ReadLine());
                int[,] matrix = new int[row, column];

                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        Console.Write($"Enter the element [{i},{j}]:");
                        matrix[i, j] = int.Parse(Console.ReadLine());
                    }
                   
                }
                Console.WriteLine("Displaying the matrix:  ");
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        Console.Write($"{matrix[i, j]}  ");

                    }
                    Console.WriteLine();
                }
                //creating transpose matrix

                int[,] transposeMatrix = new int[column, row];
                for(int i = 0; i < row; i++)
                {
                    for (int  j = 0; j < column; j++)
                    {
                        transposeMatrix[j, i] = matrix[i, j];

                    }       
                }

                Console.WriteLine("Displaying the transpose: ");
                for (int i = 0; i < column; i++)
                {
                    for (int j = 0; j < row; j++)
                    {
                        Console.Write($"{transposeMatrix[i, j]}  ");
                    }
                    Console.WriteLine();
                }

            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
