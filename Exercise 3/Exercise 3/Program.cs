using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentNames = new string[5] { "Jane Doe", "John Doe", "Billy Grame", "Jennifer Croul", "Jeff Truson" };
            List<Student> students = new List<Student> { };
            bool run = true;
            bool go = true;


            // This creates a list of classes with grades, then creates a student object to assign that list to.
            for (int i = 0; i < 5; i++)
            {
                List<Class> classes = new List<Class> { };
                Class currentclass = null;
                classes.Add(currentclass = new Class("History of Coffee", 97.32));
                classes.Add(currentclass = new Class("Flavors of the World", 82.33));
                classes.Add(currentclass = new Class("Art of the Barista", 74.98));
                classes.Add(currentclass = new Class("Tools of the Trade", 67.45));
                classes.Add(currentclass = new Class("Brand Development", 78.62));

                Student currentStudent = null;
                students.Add(currentStudent = new Student(studentNames[i], classes));
            }

            while (go)
            {
                run = true;
                Console.Clear();
                // This displays the menu.
                Console.Write("\nWelcome Instructor\n" +
                    "\nUse numbers for your selection." +
                    "\n1. Review Students" +
                    "\n2. Review Student GPAs" +
                    "\n3. Edit Student grades" +
                    "\n4. Exit" +
                    "\nSelection: ");
                string input = Console.ReadLine();
                int inputCheck = 0;

                // Checks if the input is a number and if it falls between 1 and 4.
                while (run)
                {
                    if (string.IsNullOrWhiteSpace(input) || !int.TryParse(input, out inputCheck) || inputCheck < 1 || inputCheck > 4)
                    {
                        Console.Write("\nInvalid selection, please use the numbers for your selection. ");
                        input = Console.ReadLine();
                    }
                    else
                    {
                        run = false;
                    }
                }

                // Runs actions assigned to the user choice.
                switch (input)
                {
                    case "1":
                        {
                            Console.Clear();
                            // Shows the student, class, grade, and GPA
                            Utility.ShowAll(students);
                            Console.WriteLine("Press any key to continue.");
                            Console.ReadKey();
                            break;
                        }
                    case "2":
                        {
                            Console.Clear();
                            // Shows the student and their average GPA
                            Utility.AverageGPA(students);
                            Console.WriteLine("Press any key to continue.");
                            Console.ReadKey();
                            break;
                        }
                    case "3":
                        {
                            Console.Clear();
                            run = true;
                            Console.WriteLine("\nWhich student would you like to change grades for?");
                            // Displays students to choose from
                            for (int i = 0; i < 5; i++)
                            {
                                Console.WriteLine($"{i + 1}. {students[i].Getname}");
                            }
                            Console.Write("Selection: ");
                            string studentChoice = Console.ReadLine();
                            int studentCheck = 0;

                            // Checks if the input is a number and between 1 and 5
                            while (run)
                            {
                                if (string.IsNullOrWhiteSpace(studentChoice) || !int.TryParse(studentChoice, out studentCheck) || studentCheck < 1 || studentCheck > 5)
                                {
                                    Console.Write("\nInvalid selection, please use the numbers provided. ");
                                    studentChoice = Console.ReadLine();
                                }
                                else
                                {
                                    run = false;
                                }
                            }

                            run = true;
                            Console.WriteLine("\nWhich class would you like to change grades for?");
                            // Displays the chosen students classes
                            for (int i = 0; i < 5; i++)
                            {
                                Console.WriteLine($"{i + 1}. {students[studentCheck].GetClasses[i].ClassName}");
                            }
                            Console.Write("Selection: ");
                            string classChoice = Console.ReadLine();
                            int classCheck = 0;

                            // Check if the input is a number and between 1 and 5
                            while (run)
                            {
                                if (string.IsNullOrWhiteSpace(classChoice) || !int.TryParse(classChoice, out classCheck) || classCheck < 1 || classCheck > 5)
                                {
                                    Console.Write("\nInvalid selection, please use the numbers provided. ");
                                    classChoice = Console.ReadLine();
                                }
                                else
                                {
                                    run = false;
                                }
                            }

                            run = true;
                            Console.Write("What should the new grade be? ");
                            string newGrade = Console.ReadLine();
                            double gradeCheck = 0;

                            // Checks if the input is a number and between 0 and 100
                            while (run)
                            {
                                if (string.IsNullOrWhiteSpace(newGrade) || !double.TryParse(newGrade, out gradeCheck) || gradeCheck < 0 || gradeCheck > 100)
                                {
                                    Console.Write("\nInvalid selection, please enter a valid grade. ");
                                    classChoice = Console.ReadLine();
                                }
                                else
                                {
                                    run = false;
                                }
                            }

                            // Changes the grade for the chosen student in the chosen class and notifies the user a change was made
                            students[studentCheck - 1].GetClasses[classCheck - 1].Grade = gradeCheck;
                            Console.WriteLine("The grade has been updated. Press any key to continue.");
                            Console.ReadKey();


                            break;
                        }
                    case "4":
                        {
                            go = false;
                            break;
                        }
                }
            }
        }
    }
}
