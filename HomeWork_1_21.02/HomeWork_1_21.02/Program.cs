using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork_1_Dll;

namespace HomeWork_1_21._02
{
    class Program
    {
        static void Main(string[] args)
        {
            int num_a;
            int num_b;
            int num_c;
            double x1;
            double x2;

            Console.Write("Input number a:");
            string a = Console.ReadLine();

            while (!int.TryParse(a, out num_a)||(num_a == 0))
            {
                Console.Write("Incorrect! Input number a (a!=0):");
                a = Console.ReadLine();
            }

            Console.Write("Input number b:");
            string b = Console.ReadLine();

            while (!int.TryParse(b, out num_b))
            {
                Console.Write("Incorrect! Input number b:");
                b = Console.ReadLine();
            }

            Console.Write("Input number c:");
            string c = Console.ReadLine();

            while (!int.TryParse(c, out num_c))
            {
                Console.Write("Incorrect! Input number c:");
                c = Console.ReadLine();
            }

            Console.WriteLine();
            Custom_Math.Print_equation(num_a, num_b, num_c);

            double D = Custom_Math.Discriminant(num_a, num_b, num_c);
            Console.WriteLine($"\nDiscriminant D={D}\n");

            if (D<0)
            {
                Console.WriteLine("There are no roots");
            }

            if(D==0)
            {
                x1 = Custom_Math.Root(num_a, num_b);
                Console.WriteLine($"There is one root: x1={x1}\n");
                Custom_Math.Linear_factors1(num_a, num_b, num_c, x1);
            }

            if (D>0)
            {
                Custom_Math.Roots(num_a, num_b, num_c, out x1, out x2);
                Console.WriteLine($"There are two roots:\nx1={x1}\tx2={x2}\n");
                Custom_Math.Linear_factors2(num_a, num_b, num_c, x1, x2);
            }


            Console.ReadKey();
        }
    }
}
