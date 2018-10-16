using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    class Program
    {
        static void Main(string[] args)
        {

            //create database for each student
            string[,] table = new string[15, 3] {
                { "Michael Hern", "Canton, MI", "Chicken Wings"},
                {"Joshua Zimmerman", "Taylor, MI", "Turkey" },
                 { "Lin-Z Chang", "Toledo, OH", "Ice Cream" },
                 { "Madelyn Hilty", "Oxford, MI", "Croissent" },
                 { "Nana Banahene", "Guana", "Empanadas" },
                 { "Rochelle Toles", "Mars", "Space Cheese" },
                  { "Shah Shahid", "Newark, NJ", "Chicken Wings" },
                  { "Tim Broughton", "Detroit, MI", "Chicken Parm" },
                   { "Abby Wessels", "Traverse City, MI", "Soup" },
                   { "Blake Shaw", "Los Angeles, CA", "Cannolis" },
                  { "Bob Valentic", "St. Clair Shores, MI", "Pizza" },
                   { "Jordan Owiesny", "Warren, MI", "Burgers" },
                  { "Jay Stiles", "Macomb, MI", "Pickles" },
                    { "Taylor Everts", "Caro, MI", "Cordon Bleu" },
                  {  "Jon Shaw", "Huntington Woods, MI", "Ribs" }};
            Console.WriteLine("Welcome to our C# Class.");
                Looper(table);
           
        }
        public static void Looper(string[,] table)
        {
            // prompt user to ask about a student

            while (true)
            {
                Console.WriteLine("Which student would you like to learn more about? (Enter a number 1-15):");

                try
                {
                    // give proper responses according to what user asked for 
                    int answer = int.Parse(Console.ReadLine());
                    string name = table[answer - 1, 0];
                    string homeTown = table[answer - 1, 1];
                    string favFood = table[answer - 1, 2];
                    Console.WriteLine("Student " + answer + " is " + name + ". What would you like to know about " + name + "?\n(enter \"hometown\" or \"favorite food\"): ");
                    string extraInfo = Console.ReadLine().ToLower();


                    while (extraInfo != "hometown" && extraInfo != "favorite food")
                    {
                        Console.WriteLine("input invalid. Type \"hometown\" or \"favorite food\"");
                         extraInfo = Console.ReadLine().ToLower();

                    }
                    if (extraInfo == "hometown")
                    {

                        // ask if user would like to learn about another student
                        Console.WriteLine(name + " is from " + homeTown + ".");

                    }
                    else if (extraInfo == "favorite food")
                    {
                        Console.WriteLine(name + "\'s favorite food is " + favFood + ".");
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Number out of range, please pick a number between 1 and 15");

                }
                catch (FormatException)
                {
                    Console.WriteLine("Input not correct, please try again");

                }

                Console.WriteLine("Would you like to learn about another student? y/n: ");
                string goAgain = Console.ReadLine().ToLower();
                if (goAgain == "yes" || goAgain == "y")
                {
                    continue;
                }
                if (goAgain == "no" || goAgain == "n")
                {
                    Console.WriteLine("Goodbye");
                    Console.ReadKey();
                    break;
                }
            }
        }
    }
}
