using FigureLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    class Program
    {
        public static double ValidationInput(string input)
        {
            double number;

            while (!double.TryParse(input, out number) || number < 0)
            {
                Console.WriteLine("Input number >0");
                input = Console.ReadLine();
            }
            return number;
        }

        public static void searchFigure(Figure.Quadrangle[] Figures, int index)
        {
            if (index == 0)
            {
                Console.Write($"{index} figure:");
                Figures[index].QuadrangleInfo();
            }
            else
            {
                Console.Write($"{index} figure:");
                Figures[index - 1].QuadrangleInfo();
            }
        }

        static void Main(string[] args)
        {
            string selectInput;
            do
            {
                Console.Clear();
                Console.WriteLine($"Select the option:\n\"1\" - add new figure\n\"2\" - print all figures\n\"3\" - print information about any figure");

                string selectOption = Console.ReadLine();

                switch (selectOption)
                {
                    case "1":
                        {
                            Console.WriteLine("Please,input information about figure:");
                            Console.Write("Width:");

                            string width = Console.ReadLine();
                            double widthInt = ValidationInput(width);

                            Console.Write("Height:");

                            string height = Console.ReadLine();
                            double heightInt = ValidationInput(height);

                            Figure.Quadrangle figure = Figure.NewFigure(widthInt, heightInt);
                            figure.QuadrangleInfo();

                            Figure.AddFiguresInArray.Figures = Figure.AddFiguresInArray.AddQuadrangle(figure);
                            Figure.countOfFigures++;

                            break;
                        }

                    case "2":
                        {
                            for (int i = 0; i < Figure.countOfFigures; i++)
                            {
                                Console.Write($"{1 + i} figure:");
                                Figure.AddFiguresInArray.Figures[i].QuadrangleInfo();
                            }
                            break;
                        }

                    case "3":
                        {
                            Console.WriteLine("Input number of figure:");

                            string InputNumber = Console.ReadLine();
                            int numberOfFigure = (int)ValidationInput(InputNumber);
                            searchFigure(Figure.AddFiguresInArray.Figures, numberOfFigure);
                            break;
                        }
                }
                Console.WriteLine("Return to menu? Press \"Y\" or \"y\" - return to menu or any key to exit");

                selectInput = Console.ReadLine();
            }

            while (selectInput.Equals("y") || selectInput.Equals("Y"));

            Console.ReadKey();
        }
    }
}
