using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HomeWork_1_Dll
{
    public class Custom_Math
    {     
        public static string Replace_b(int b)
            {
                 string b2 = b == 0 ? $"" : ((b < 0 && b != 0) ? $"{b}x" : $"+{b}x");
                 return b2;
            }        
            public static string Replace_c(int c)
            {
                string c2 = c==0?$"":((c < 0 && c != 0) ? $"{c}":$"+{c}");
                return c2;
            }   
        public static void Print_equation(int a, int b, int c)
        {
            string b1 = Replace_b(b);
            string c1 = Replace_c(c);
            Console.WriteLine($"{a}x^2{b1}{c1}=0");
        }
        public static double Discriminant(int a, int b, int c)
        {
            double D;
            D = Math.Pow(b, 2) - 4 * a * c;
            return D;
        }

        public static double Root(int a, int b)
        {
            double x1;
            x1 = -(b / (2 * a));
            return x1;
        }
        public static void Roots(int a, int b, int c, out double x1, out double x2)
        {          
            double D = Discriminant(a, b, c);
            x1 = Math.Round((-b - Math.Sqrt(D)) / (2 * a),2);
            x2 = Math.Round((-b + Math.Sqrt(D)) / (2 * a),2);         
        }
        public static string Replace_x1(double x1)
        {
            string X1 = (x1 < 0) ? $"(x+{-x1})" : $"(x-{x1})";
            return X1;
        }

        public static string Replace_x2( double x2)
        {
            string X2 = (x2 < 0) ? $"(x+{-x2})" : $"(x-{x2})";
            return X2;
        }
        public static void Linear_factors1(int a, int b, int c, double x1)
        {
            string b1 = Replace_b(b);
            string c1 = Replace_c(c);
            string X1 = Replace_x1(x1);
            Console.WriteLine("Linear factors:" + " " + $"{a}x^2{b1}{c1}={a}{X1}^2");
        }

        public static void Linear_factors2(int a, int b, int c, double x1, double x2)
        {
            string b1 = Replace_b(b);
            string c1 = Replace_c(c);
            string X1 = Replace_x1(x1);
            string X2 = Replace_x2(x2);
            Console.WriteLine("Linear factors:" + " " + $"{a}x^2{b1}{c1}={a}{X1}{X2}");
           
        }

    }
}
