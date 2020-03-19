using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3Skier
{
    class Program
    {
        public static int Validation(string a) //data entry validation
        {
            int number;
        
            while (!int.TryParse(a, out number) || number < 1)
            {
                Console.Write("Incorrect! Input number (!=0):");
                a = Console.ReadLine();
            }
            return number;
        }
        static void Main(string[] args)
        {
            int num_x; //the number of kilometers skier ran in 1st day
            int num_y;//% which increased mileage
            int num_z;//arbitrary number of km for comparison
            List<int> Days = new List<int>();//list to display information about days of all skiers
            List<int> Km = new List<int>();//list to display information about distance of all skiers

            string select;
            do
            {
                Console.WriteLine("Input the number of km in 1 day !=0:");
                string x1 = Console.ReadLine();
                num_x = Validation(x1);
                
                do
                {
                    Console.WriteLine("Input % which increases mileage !=0:");
                    string y1 = Console.ReadLine();
                    num_y = Validation(y1);
                }
                while (num_y > 100);

                Console.WriteLine("Input any number of km: ");
                string z1 = Console.ReadLine();
                num_z = Validation(z1);

                int Skier=SkierDll.MathSkier.CheckDay(num_x, num_y, num_z);
                Console.WriteLine($"On {Skier} day the total mileage for all days will exceed {num_z} km.");

                Days.Add(Skier);//add data to the list to display information about all skiers     
                Km.Add(num_z);//add data to the list to display information about all skiers

                Console.WriteLine("\nDo you want to continue with another sportsman? Press Y or any key - to display information about all skiers\n");
                select = Console.ReadLine();

            }
            while (select == "y");
           
                for (int i = 0; i < Days.Count; i++)
                {
                    Console.WriteLine($"Results of all skiers:\n The {i + 1} skier: On {Days[i]} day the total mileage for all days will exceed {Km[i]} km");
                }
            

            
            




            Console.ReadKey();
        }
    }
}
