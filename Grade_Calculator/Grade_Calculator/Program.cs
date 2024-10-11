/*
Olivia Gauthier
IGME 201
October 13,2024
*/

namespace Grade_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables
            string studentName = "Olivia Gauthier";
            int[] grades = { 100, 92, 87, 200, -20, 52, 82, 75, 67, 88 };
            int average = 0;

            //start of program
            Console.WriteLine("Welcome " + studentName + "!");
            Console.WriteLine("Here are your grades:");

            //iterate through each of the grades in the array
            for (int i = 0; i < grades.Length; i++)
            {
                //add each grade to the average
                average += grades[i];

                Console.WriteLine(grades[i]);
                //if else statement to figure out which output to display
                if (100 >= grades[i] && grades[i] >= 90)
                {
                    Console.WriteLine("This grade is an A!");
                    if (grades[i] == 100)
                    {
                        Console.WriteLine("WOW! A perfect score!");
                    }
                }
                else if (89 >= grades[i] && grades[i] >= 80)
                {
                    Console.WriteLine("This grade is a B.");
                }
                else if (79 >= grades[i] && grades[i] >= 70)
                {
                    Console.WriteLine("This grade is a C.");
                }
                else if (69 >= grades[i] && grades[i] >= 65)
                {
                    Console.WriteLine("This grade is a D.");
                } else if (64 >= grades[i] && grades[i] >= 0)
                {
                    Console.WriteLine("This grade is an F.");
                } else
                {
                    Console.WriteLine("This is out of the range of 0-100. How did you even get this grade?");
                }
            }
            //divide average by length of grades array
            average = average / grades.Length;
            Console.WriteLine("Your final calculated average is: " + average);
            Console.WriteLine("We have displayed all grades for " + studentName);
        }
    }
}
