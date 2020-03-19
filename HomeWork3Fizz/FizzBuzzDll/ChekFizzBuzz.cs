using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzDll
{
   public class ChekFizzBuzz
    {
        public static string[] ChekNumbers(int a, int b, int f1, int f2)
        {
            string[] result = new string[80];

            int j=0;
                for (int i = a; i <= b; i++)
                {
                     if(i % f1 == 0 && i % f2 == 0)
                     {
                            result[j+1] = "FizzBuzz" + $" - {i}";
                            j++;
                     }
                     else if (i % f1 == 0)
                     {
                            result[j+1] = "Fizz" + $" - {i}";
                            j++;
                     }
                    
                     else if (i % f2 == 0)
                     {
                        result[j+1] = "Buzz" + $" - {i}";
                        j++;
                     }               
                }
             return result;
        }

        public static bool ChekPrimeFactors(int n)//prime factor check
        {
            var result = true;
            if (n > 1)
            {
                for (var i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        result = false;
                        break;
                    }
                }
            }
            else
            {
                result = false;
            }
            return result;
        }



    }
}
