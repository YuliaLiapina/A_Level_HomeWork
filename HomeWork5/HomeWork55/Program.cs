using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatricesLibrary;

namespace HomeWork55
{
    class Program
    {
        public static int countMatricies = 0;

        public static void PrintSteppedArray(int[][,] steppedArray)
        {
            for (int k = 0; k < countMatricies; k++)
            {
                for (int i = 0; i < steppedArray[k].GetLength(0); i++)
                {
                    for (int j = 0; j < steppedArray[k].GetLength(1); j++)
                    {
                        Console.Write(steppedArray[k][i, j] + "\t");
                    }
                    Console.WriteLine("\n");
                }
                Console.WriteLine("=========================================");
            }
        }

        public static int ValidationInput(string input)
        {
            int number;

            while (!int.TryParse(input, out number) || number < 0)
            {
                Console.WriteLine("Input number >0");
                input = Console.ReadLine();
            }
            return number;
        }

        public static void PrintMatrices(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
        }

        static void Main(string[] args)
        {

            string selectAgain;

            do
            {
                Console.Clear();
                Console.WriteLine("Enter matrix dimension:");

                string dimensionStr = Console.ReadLine();
                int N = ValidationInput(dimensionStr);
                int[,] matrix = new int[N, N];

                Console.WriteLine($"Select the option:\npress \"1\" - Display matrix\npress \"2\" - Enter N and generate a new matrix\npress \"3\" - Exit the program" +
                    $"\npress \"4\" - Display Transposed matrix\npress \"5\" - Display UpperTriangularMatrix\npress \"6\" - Display LowerTriangularMatrix\npress \"7\" - Display all matricies");

                string selectOption = Console.ReadLine();
                switch (selectOption)
                {
                    case "1":
                        {
                            PrintMatrices(Matrices.InitializationMatrix(matrix));
                            SteppedArray.addMatrix(matrix);
                            countMatricies++;
                            break;
                        }

                    case "2":
                        {
                            Console.WriteLine("Enter matrix dimension:");

                            dimensionStr = Console.ReadLine();
                            N = ValidationInput(dimensionStr);
                            matrix = new int[N, N];
                            PrintMatrices(Matrices.InitializationMatrix(matrix));
                            SteppedArray.addMatrix(matrix);
                            countMatricies++;
                            break;
                        }

                    case "3":
                        {
                            return;
                        }

                    case "4":
                        {
                            PrintMatrices(Matrices.InitializationMatrix(matrix));
                            SteppedArray.addMatrix(matrix);
                            countMatricies++;
                            Console.WriteLine("=========================================");
                            Console.WriteLine("\nTransposed matrix:\n");
                            Matrices.TransposedMatrix(matrix);
                            break;
                        }

                    case "5":
                        {
                            PrintMatrices(Matrices.InitializationMatrix(matrix));
                            SteppedArray.addMatrix(matrix);
                            countMatricies++;
                            Console.WriteLine("=========================================");
                            Console.WriteLine("\nUpper triangular matrix:\n");
                            PrintMatrices(Matrices.UpperTriangularMatrix(matrix));
                            break;
                        }

                    case "6":
                        {
                            PrintMatrices(Matrices.InitializationMatrix(matrix));
                            SteppedArray.addMatrix(matrix);
                            countMatricies++;
                            Console.WriteLine("=========================================");
                            Console.WriteLine("\nLower  triangular matrix:\n");
                            PrintMatrices(Matrices.LowerTriangularMatrix(matrix));
                            break;
                        }

                    case "7":
                        {
                            Console.Clear();

                            Console.WriteLine("All matrices:");
                            PrintSteppedArray(SteppedArray.steppedArray);
                            break;
                        }
                }

                Console.WriteLine("Again? - Press \"y\"");
                selectAgain = Console.ReadLine();

            }

            while (selectAgain.Equals("y"));

















            Console.ReadKey();
        }
    }
}
