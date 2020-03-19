using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocksLibrary;

namespace HomeWork4
{
    class Program
    {

        public static int ValidationInput(string input)
        {
            int number;

            while (!int.TryParse(input, out number) || number < 0 || number > 50)
            {
                Console.Write("Incorrect! Enter the size according to the selected category: ");
                input = Console.ReadLine();
            }
            return number;
        }

        public static int ValidationInputCategory(string input)
        {
            int number;

            while (!int.TryParse(input, out number) || number < 0 || number > 4)
            {
                Console.Write("Incorrect! Input number from 1, 2 or 3:");
                input = Console.ReadLine();
            }
            return number;
        }
        public static int ValidationSizeByGender(int size, GenderCategory category)
        {

            if (category == GenderCategory.man)
            {
                while (size < 40 || size > 49)
                {
                    Console.Write("Incorrect! Size should be from 40 to 49");
                    string input = Console.ReadLine();
                    size = ValidationInput(input);
                }
            }

            else if (category == GenderCategory.woman)
            {
                while (size < 35 || size > 39)
                {
                    Console.Write("Incorrect! Size should be from 35 to 39");
                    string input = Console.ReadLine();
                    size = ValidationInput(input);
                }
            }

            else if (category == GenderCategory.kids)
            {
                while (size < 18 || size > 34)
                {
                    Console.Write("Incorrect! Size should be from 18 to 34");
                    string input = Console.ReadLine();
                    size = ValidationInput(input);
                }
            }
            return size;
        }
        static void Main(string[] args)
        {
            int numbOfProductValid;
            string numbOfProduct;
            string selectKey;
            string selectOption;
            int countSock = 1;

            do
            {
                Console.Clear();

                Console.WriteLine($"Select the option:\npress \"1\" - Input information about socks\npress \"2\" - Show the list of all products\npress \"3\" - Show information about 1 product" +
                    $"\npress \"4\" - Delete one product\npress \"5\" - Exit programm");

                selectOption = Console.ReadLine();

                switch (selectOption)
                {
                    case "1":
                        {
                            Console.WriteLine("Please, input information about socks :)\n");

                            Console.Write("1. Brand of socks:");
                            string brandOfSocks = Console.ReadLine();

                            Console.Write("2. Gender category: 1-man, 2-woman, 3-kids:");
                            string genderString = Console.ReadLine();
                            int gender = ValidationInputCategory(genderString);
                            GenderCategory genderCategory = (GenderCategory)gender;
                            Console.Write($"You selected category: " + genderCategory.ToString() + "\n");

                            Console.Write("3. Size:");
                            string sizeString = Console.ReadLine();
                            int size = ValidationInput(sizeString);
                            int sizeAfterValidation = ValidationSizeByGender(size, genderCategory);

                            Console.Write("4. Color:");
                            string color = Console.ReadLine();

                            Console.Write("5. Material:");
                            string material = Console.ReadLine();

                            Socks socks = new Socks(countSock, brandOfSocks, genderCategory, sizeAfterValidation, color, material);

                            ListOfSocks.addSocks(socks);

                            Console.WriteLine(socks.ToString());

                            countSock += 1;
                            break;
                        }

                    case "2":
                        {
                            Console.Clear();

                            Console.WriteLine($"The list of all products:");
                            foreach (var item in ListOfSocks.listOfSocks)
                            {
                                Console.WriteLine(item.ToString());
                            }
                            break;
                        }

                    case "3":
                        {
                            Console.WriteLine($"Enter the product number, for more details:");

                            numbOfProduct = Console.ReadLine();
                            numbOfProductValid = ValidationInput(numbOfProduct);

                            for (int i = 0; i < ListOfSocks.listOfSocks.Count; i++)
                            {
                                if (ListOfSocks.listOfSocks[i].CountSock.Equals(numbOfProductValid))
                                {
                                    Console.WriteLine(ListOfSocks.listOfSocks[i].ToString());
                                }
                            }
                            break;
                        }

                    case "4":
                        {
                            Console.WriteLine($"\nEnter the product number to remove it from this list:");

                            foreach (var item in ListOfSocks.listOfSocks)
                            {
                                Console.WriteLine(item.ToString());
                            }

                            numbOfProduct = Console.ReadLine();
                            numbOfProductValid = ValidationInput(numbOfProduct);

                            for (int i = 0; i < ListOfSocks.listOfSocks.Count; i++)
                            {
                                if (ListOfSocks.listOfSocks[i].CountSock.Equals(numbOfProductValid))
                                {
                                    ListOfSocks.listOfSocks.RemoveAt(i);
                                    i--;
                                }
                            }

                            foreach (var item in ListOfSocks.listOfSocks)
                            {
                                Console.WriteLine(item.ToString());
                            }

                            break;
                        }

                    case "5":
                        {
                            return;
                        }
                }

                Console.WriteLine("Do you want return to menu? - press \"y\"");
                selectKey = Console.ReadLine();
            }

            while (selectKey.Equals("y"));






            Console.ReadKey();
        }
    }
}
