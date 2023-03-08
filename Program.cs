using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocolateReviewsSQL
{
    class Program
    {
        static void Main(string[] args)
        {
            bool quit = false;

            while (!quit)
            {
                Console.WriteLine("Welcome to the chocolate bar review console");
                Console.WriteLine("Main Menu");
                Console.WriteLine("---------");
                Console.WriteLine("1) Show reviews");
                Console.WriteLine("2) Add new review");
                Console.WriteLine("3) Update review");
                Console.WriteLine("4) Delete review");
                Console.WriteLine("Q) Quit");

                string choice = Console.ReadLine().ToUpper();
                quit = choice == "Q";

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Showing reviews");
                        break;

                    case "2":
                        Console.WriteLine("Adding review");
                        break;

                    case "3":
                        Console.WriteLine("Updating review");
                        break;

                    case "4":
                        Console.WriteLine("Deleting review");
                        break;

                    case "Q":
                        quit = true;
                        break;

                    default:
                        Console.WriteLine("Error: Invalid choice");
                        break;
                }
            }
        }
    }
}
