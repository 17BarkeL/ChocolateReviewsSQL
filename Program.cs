using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocolateReviewsSQL
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"W:\008.Computing\\Student work\\2022 - 2023\\Y12\\Luke Barkess\\ChocolateReviewsSQL\\Reviews.mdf\";Integrated Security=True";

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;
            connection.Open();
            Console.WriteLine("Open sus?");
            connection.Close();

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
                Console.WriteLine("5) Show all users");
                Console.WriteLine("6) Add user");
                Console.WriteLine("7) Update user");
                Console.WriteLine("8) Delete user");
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

                    case "5":
                        Console.WriteLine("Showing all users");
                        break;

                    case "6":
                        Console.WriteLine("Adding user");
                        break;

                    case "7":
                        Console.WriteLine("Updating user");
                        break;

                    case "8":
                        Console.WriteLine("Deleting user");
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
