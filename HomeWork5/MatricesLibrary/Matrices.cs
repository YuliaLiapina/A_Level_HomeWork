using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatricesLibrary
{
    public class Matrices
    {

        public static int[,] InitializationMatrix(int[,] matrix)
        {
            Random rand = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rand.Next(1, 100);
                }
            }
            return matrix;
        }

        public static void TransposedMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[j, i] + "\t");
                }
                Console.WriteLine("\n");
            }
        }

        public static int[,] UpperTriangularMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i > j)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            return matrix;
        }

        public static int[,] LowerTriangularMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j > i)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            return matrix;
        }
    }

    public static class SteppedArray
    {
        public static int[][,] steppedArray = new int[15][,];
        static int i = 0;
        public static int[][,] addMatrix(int[,] matrix)
        {
            steppedArray[i] = matrix;
            i++;
            return steppedArray;
        }
    }
}

