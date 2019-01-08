using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> colorAndFacts = new Dictionary<string, List<string>> { };

            List<string> redFacts = new List<string> { "Red means beautiful in Russian.","The color red doesn't make bulls angry, they are color-blind.","Seeing the color red makes your heart beat faster."};
            List<string> orangeFacts = new List<string> { "Orange means high in the color-coded threat system.","The blood on the set of Sweeney Todd had to be orange to show up properly in the film.","Orange is the Dutch Royal Family's color."};
            List<string> yellowFacts = new List<string> { "In Japan, yellow is the color for courage.","In Egypt, yellow is the color of mourning.","Yellow is psychologicaly the happiest color."};
            List<string> greenFacts = new List<string> { "Green is the second most popular color.","Santa's suit used to be green before Coka-Cola changed it in the 1950s.","The human can distinguish the most shades of the color green."};
            List<string> blueFacts = new List<string> { "Blue is the color most preferred by men.","Blue is thought to bring bad luck in India.","8% of the world's population have blue eyes."};
            List<string> indigoFacts = new List<string> { "Indigo is also known as ultramarine.","Indigo originated in India.","Indigo is used in making Royal Purple."};
            List<string> violetFacts = new List<string> { "Violet isn't part of the visible spectrum, so you can't see it in a rainbow.","Carrots used to be violet.","Dominica is the only nation with violet on its flag."};
            List<string> colors = new List<string> { "red", "orange", "yellow", "green", "blue", "indigo", "violet" };

            colorAndFacts.Add(colors[0], redFacts);
            colorAndFacts.Add(colors[1], orangeFacts);
            colorAndFacts.Add(colors[2], yellowFacts);
            colorAndFacts.Add(colors[3], greenFacts);
            colorAndFacts.Add(colors[4], blueFacts);
            colorAndFacts.Add(colors[5], indigoFacts);
            colorAndFacts.Add(colors[6], violetFacts);

            bool go = true;

            // This keeps the program going until the user is done.
            while (go)
            {
                Console.Clear();
                // This displays the menu.
                Console.Write("What is your favorite color?" +
                    "\n1. Red" +
                    "\n2. Orange" +
                    "\n3. Yellow" +
                    "\n4. Green" +
                    "\n5. Blue" +
                    "\n6. Indigo" +
                    "\n7. Violet" +
                    "\n8. Exit" +
                    "\nSelection: ");
                string input = Console.ReadLine().ToLower();
                int inputCheck = 0;

                // This checks for null, white space, if the input is a number, and if that number falls btween 1 and 8.
                while (string.IsNullOrWhiteSpace(input) || !int.TryParse(input, out inputCheck) || inputCheck < 1 || inputCheck > 8)
                {
                    Console.Write("Invalid selection, please type a color or number. ");
                    input = Console.ReadLine().ToLower();
                }

                // This is all the outputs for the various choices the user has
                switch (input)
                {
                    case "1":
                    case "red":
                        {
                            Console.Clear();
                            // This writes the facts for the chosen color.
                            for (int i = 0; i < 3; i++)
                            {
                                Console.WriteLine(colorAndFacts[colors[0]][i]);
                                Console.WriteLine("--------------------------------");
                            }
                            Console.ReadKey();
                            break;
                        }
                    case "2":
                    case "orange":
                        {
                            Console.Clear();
                            // This writes the facts for the chosen color.
                            for (int i = 0; i < 3; i++)
                            {
                                Console.WriteLine(colorAndFacts[colors[1]][i]);
                                Console.WriteLine("--------------------------------");
                            }
                            Console.ReadKey();
                            break;
                        }
                    case "3":
                    case "yellow":
                        {
                            Console.Clear();
                            // This writes the facts for the chosen color.
                            for (int i = 0; i < 3; i++)
                            {
                                Console.WriteLine(colorAndFacts[colors[2]][i]);
                                Console.WriteLine("--------------------------------");
                            }
                            Console.ReadKey();
                            break;
                        }
                    case "4":
                    case "green":
                        {
                            Console.Clear();
                            // This writes the facts for the chosen color.
                            for (int i = 0; i < 3; i++)
                            {
                                Console.WriteLine(colorAndFacts[colors[3]][i]);
                                Console.WriteLine("--------------------------------");
                            }
                            Console.ReadKey();
                            break;
                        }
                    case "5":
                    case "blue":
                        {
                            Console.Clear();
                            // This writes the facts for the chosen color.
                            for (int i = 0; i < 3; i++)
                            {
                                Console.WriteLine(colorAndFacts[colors[4]][i]);
                                Console.WriteLine("--------------------------------");
                            }
                            Console.ReadKey();
                            break;
                        }
                    case "6":
                    case "indigo":
                        {
                            Console.Clear();
                            // This writes the facts for the chosen color.
                            for (int i = 0; i < 3; i++)
                            {
                                Console.WriteLine(colorAndFacts[colors[5]][i]);
                                Console.WriteLine("--------------------------------");
                            }
                            Console.ReadKey();
                            break;
                        }
                    case "7":
                    case "violet":
                        {
                            Console.Clear();
                            // This writes the facts for the chosen color.
                            for (int i = 0; i < 3; i++)
                            {
                                Console.WriteLine(colorAndFacts[colors[6]][i]);
                                Console.WriteLine("--------------------------------");
                            }
                            Console.ReadKey();
                            break;
                        }
                    case "8":
                    case "exit":
                        {
                            go = false;
                            break;
                        }
                }
            }
        }
    }
}
