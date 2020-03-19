using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary
{
    public struct Figure
    {
        public static int countOfFigures = 0;
        public struct Quadrangle
        {
            public double width;
            public double height;

            public static double Area(double width, double height)
            {
                double area = width * height;
                return area;
            }

            public void QuadrangleInfo()
            {
                Console.WriteLine($" Width - {width}\tHeight - {height}\tArea - {Area(width, height)}");
            }
        }

        public struct AddFiguresInArray
        {
            public static int i = 0;
            public static Quadrangle[] Figures = new Quadrangle[10];
            public static Quadrangle[] AddQuadrangle(Quadrangle quadrangle)
            {
                Figures[i] = quadrangle;
                i++;
                return Figures;
            }
        }

        public static Quadrangle NewFigure(double width, double height)
        {
            Quadrangle figure;

            figure.width = width;
            figure.height = height;

            return figure;
        }
    }
}
