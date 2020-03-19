using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HomeWork3Fizz
{
    class Program
    {
        public static int Validation(string a)//data entry validation
        {
            int number;
            while (!int.TryParse(a, out number) || number < 1 || number > 100)
            {
                Console.Write("Incorrect! Input number from 1 to 100:");
                a = Console.ReadLine();
            }
            return number;
        }
        static void Main(string[] args)
        {
            int num1;//1st number og range
            int num2;//2nd number og range

            Console.WriteLine("Please, enter 1st number of  range(from 1 to 100):");
                string n1 = Console.ReadLine();
                num1 = Validation(n1);
            do
            {
                Console.WriteLine("Please, enter 2nd number of  range - more than the 1st number(from 1 to 100):");
                string n2 = Console.ReadLine();
                num2 = Validation(n2);
            }
            while (num1 > num2);// the final number cannot be less than the initial

            Console.WriteLine("Please, enter 1st prime factor: ");
            string factor1 = Console.ReadLine();
            int f1= Validation(factor1);
            while (FizzBuzzDll.ChekFizzBuzz.ChekPrimeFactors(f1) == false)
            {
                Console.WriteLine("Your number is not a prime factor. Try again:");
                f1 = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Please, enter 2st prime factor: ");
            string factor2 = Console.ReadLine();
            int f2 = Validation(factor2);
            while (FizzBuzzDll.ChekFizzBuzz.ChekPrimeFactors(f2) == false)
            {
                Console.WriteLine("Your number is not a prime factor. Try again:");
                f2 = int.Parse(Console.ReadLine());
            }         

            foreach (var item in FizzBuzzDll.ChekFizzBuzz.ChekNumbers(num1, num2, f1, f2))
            {
                Console.Write(item + "\n");
            }

            Console.ReadKey();
        }
    }
}
