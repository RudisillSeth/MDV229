using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Utility
    {
        static public void ShowAll(List<Student> stu)
        {
            List<Student> students = stu;

            for (int i = 0; i < 5; i++)
            {
                // Writes the students and all information about them
                Console.WriteLine($"Student : {students[i].Getname}");
                for (int x = 0; x < 5; x++)
                {
                    Console.WriteLine("+--------------------------------+");
                    Console.WriteLine($"|{students[i].GetClasses[x].ClassName} : {students[i].GetClasses[x].Grade} {GPACheck(students[i].GetClasses[x].Grade)}   ");
                }
                Console.WriteLine("+--------------------------------+\n");
            }
        }

        // Takes the grade for a class and find the GPA
        static string GPACheck(double grade)
        {
            double check = grade;

            if (check > 89.4 && check < 101)
            {
                return "A";
            }
            else if (check > 79.4 && check < 89.5)
            {
                return "B";
            }
            else if (check > 72.4 && check < 79.5)
            {
                return "C";
            }
            else if (check > 69.4 && check < 72.5)
            {
                return "D";
            }
            else { return "F"; }
        }

        // Takes all the grades of the students and turns them into their average GPA
        public static void AverageGPA(List<Student> stu)
        {
            List<Student> students = stu;
            
            // This takes each student's grades and converts them into the student's GPA
            for (int i = 0; i < 5; i++)
            {
                double total = 0;
                Console.WriteLine($"Student : {students[i].Getname}");
                for (int x = 0; x < 5; x++)
                {
                    double check = students[i].GetClasses[x].Grade;
                    int gpa = 0;

                    if (check > 89.4 && check < 101)
                    {
                        gpa = 4;
                    }
                    else if (check > 79.4 && check < 89.5)
                    {
                        gpa = 3;
                    }
                    else if (check > 72.4 && check < 79.5)
                    {
                        gpa = 2;
                    }
                    else if (check > 69.4 && check < 72.5)
                    {
                        gpa = 1;
                    }
                    else { gpa = 0; }

                    total += gpa;
                }
                Console.WriteLine("+----------------+");
                Console.WriteLine($"|Average GPA : {NumtoLetterGPA(total / 5)} |");
                Console.WriteLine("+----------------+\n");
            }

        }

        // Takes the numerical average and change it to a letter GPA
        static string NumtoLetterGPA(double total)
        {
            double check = total;
            string letterGPA = null;

            if (check < 4.1 && check > 3.0)
            {
                letterGPA = "A";
            }
            else if (check < 3.1 && check > 2.0)
            {
                letterGPA = "B";
            }
            else if (check < 2.1 && check > 1.0)
            {
                letterGPA = "C";
            }
            else if (check < 1.1 && check > 0.0)
            {
                letterGPA = "D";
            }
            else { letterGPA = "F"; }

            return letterGPA;
        }
    }
}
