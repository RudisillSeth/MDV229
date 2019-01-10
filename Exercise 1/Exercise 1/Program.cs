using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            bool go = true;
            string[] coffeeBrands = new string[20] { "Folgers", "Maxwell House", "Eight O'Clock", "Nescafe", "Chock full o' Nuts", "Milestone Coffee", "Tossimo", "Jacobs", "Sanka", "Kenco", "MJB", "Mr. Brown", "Boss Coffee", "Georgia", "Moccana", "Nabob", "Senseo", "Highpoint", "Red Circle", "State House" };
            string[] backup = new string[20] { "Folgers", "Maxwell House", "Eight O'Clock", "Nescafe", "Chock full o' Nuts", "Milestone Coffee", "Tossimo", "Jacobs", "Sanka", "Kenco", "MJB", "Mr. Brown", "Boss Coffee", "Georgia", "Moccana", "Nabob", "Senseo", "Highpoint", "Red Circle", "State House" };

            // This lets the whole thing repeat until the user is done.
            while (go)
            {
                Console.Clear();
                Array.ForEach(coffeeBrands, x => Console.WriteLine(x));

                // This displays the menu.
                Console.Write("\nWhat would you like to do to the list?\n" +
                    "1. Alphabetize the list.\n" +
                    "2. Reverse Alphabetize the list.\n" +
                    "3. Randomly remove them all.\n" +
                    "4. Restore the list.\n" +
                    "5. Exit\n" +
                    "Type the number for your selection: ");
                string input = Console.ReadLine();
                int inputCheck = 0;

                // This sets up the loop to check if the input is a number.
                while (run)
                {
                    // This sees if the input cannot be parsed, white space, null, and between the desired numbers.
                    if (!int.TryParse(input, out inputCheck) || string.IsNullOrWhiteSpace(input) || inputCheck < 1 || inputCheck > 4)
                    {
                        // This lets the user know their input was wrong and the correct input to use.
                        Console.Write("\nInvalid selection, please use the numbers for your selection. ");
                        input = Console.ReadLine();
                    }
                    // This breaks the loop if all checks are passed
                    else
                    {
                        run = false;
                    }
                }

                // This sets up the various functions of the menu.
                switch (input)
                {
                    case "1":
                        {
                            // This clears the screen of clutter, sorts the list, writes the list out, lets the user know the function is complete, then waits for a key to be pressed.
                            if (coffeeBrands.Count() == 0)
                            {
                                Console.WriteLine("The list is empty.");
                            }
                            else
                            {
                                Console.Clear();
                                Array.Sort(coffeeBrands);
                                Array.ForEach(coffeeBrands, x => Console.WriteLine(x));
                                Console.Write("\nThe list is now alphabetized, press any key to continue.");
                                Console.ReadKey();
                            }
                            break;
                        }
                    case "2":
                        {
                            // This does the same as case 1 with the exception of reversing the order after sorting.
                            if (coffeeBrands.Count() == 0)
                            {
                                Console.WriteLine("The list is empty.");
                            }
                            else
                            {
                                Console.Clear();
                                Array.Sort(coffeeBrands);
                                Array.Reverse(coffeeBrands);
                                Array.ForEach(coffeeBrands, x => Console.WriteLine(x));
                                Console.Write("\nThe list is now alphabetized in reverse, press any key to continue.");
                                Console.ReadKey();
                            }
                            break;
                        }
                    case "3":
                        {
                            // This generates a number between the avalible numbers, then deletes the entry at that number, displays what is left, then repeats until all entries are deleted.
                            Console.Clear();
                            if (coffeeBrands.Count() == 0)
                            {
                                Console.WriteLine("No list to remove from.");
                            }
                            else
                            {
                                while (coffeeBrands.Count() > 0)
                                {
                                    int rNum = new Random().Next(coffeeBrands.Count());

                                    List<string> Brands = coffeeBrands.ToList();
                                    Console.WriteLine($"{Brands[rNum]} removed");
                                    Brands.RemoveAt(rNum);
                                    coffeeBrands = Brands.ToArray();

                                    Thread.Sleep(500);
                                }
                                Console.Write("\nAll brands have been removed, press any key to continue.");
                                Console.ReadKey();
                            }
                            break;
                        }
                    case "4":
                        {
                            // This uses an identical array to recover the clothingBrands array.
                            Console.Clear();
                            coffeeBrands = backup;
                            Console.Write("The brands have been restored, press any key to continue.");
                            Console.ReadKey();
                            break;
                        }
                    case "5":
                        {
                            // This ends the loop and exits the program.
                            go = false;
                            break;
                        }
                }
            }
        }
    }
}
