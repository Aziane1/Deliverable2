/*
Author: Adam Aziane 
Date: 01/19/2023
Descroiption: Grading rubric project, gives the grade after entering the percentage
*/

using System;
using System.Linq.Expressions;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a numeric grade: ");
            try
            {
                int grade = int.Parse(Console.ReadLine());

                string letter;

                if (grade >= 90)
                {
                    letter = "A";
                    Console.WriteLine("Your expected letter grade for ISM 4300 is: " + letter);
                }
                else if (grade >= 80 && grade < 90)
                {
                    letter = "B";
                    Console.WriteLine("Your expected letter grade in ISM 4300 is: " +  letter);
                }
                else if (grade >= 70 && grade < 80)
                {
                    letter = "C";
                    Console.WriteLine("Your expected letter grade in ISM 4300 is: " + letter);
                }
                else if (grade >= 60 && grade < 70 )
                {
                    letter = "D";
                    Console.WriteLine("Your expected letter grade in ISM 4300 is: " + letter);
                }
                else
                {
                    letter = "F";
                    Console.WriteLine("Your expected letter grade in ISM 4300 is: " + letter);
                }
                
            }
            catch
            {
                Console.WriteLine("Enter a numeric Value");
            }
        }
    }
}