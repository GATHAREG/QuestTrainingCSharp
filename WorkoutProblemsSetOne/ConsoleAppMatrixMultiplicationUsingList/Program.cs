using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMatrixMultiplicationUsingList
{
    internal class Program
    {
        static List<List<int>> Multiply(List<List<int>> matrixA, List<List<int>> matrixB)
        {
            int rowsA = matrixA.Count;
            int colsA = matrixA[0].Count;
            int rowsB = matrixB.Count;
            int colsB = matrixB[0].Count;
            if(colsA != rowsB)
            {
                Console.WriteLine("These matrices cannot be multiplied.");
            }
            
            var result = new List<List<int>>(rowsA);
            for (int i = 0; i < rowsA; i++)
            {
                result.Add(new List<int>(new int[colsB]));
            }
            for (int i = 0; i < rowsA; i++)
            {
                for(int j = 0;j<colsB; j++)
                {
                    
                    for(int k = 0; k < colsA; k++)
                    {
                        result[i][j] += matrixA[i][k] * matrixB[k][j]; 
                    }
                    
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            List<List<int>> matrixOne = new List<List<int>>
            {
                new List<int>{1,2, 3},
                new List<int> {4,5,6}
            };

            List<List<int>> matrixTwo = new List<List<int>>
            {
                new List<int>{4,5, 6},
                new List<int> {7,8,9},
                new List<int>{1,2,3}
            };
            try
            {
                var result = Multiply(matrixOne, matrixTwo);
                foreach (var item in result)
                {
                    foreach (var res in item)
                    {
                        Console.Write($"{res} ");
                    }
                    Console.WriteLine();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



        }
    }
}
