using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XYZUniversity.ResuktCalculator;

namespace StudentResultCalConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, result;
            double average;
            int subject1Mark, subject2Mark, subject3Mark;

            //input- UI Logic
            Console.Write("Enter the name of the student:");
            name = Console.ReadLine();
            Console.Write("Enter Subject 1 marks: ");
            subject1Mark = int.Parse(Console.ReadLine());
            Console.Write("Enter Subject 2 marks: ");
            subject2Mark = int.Parse(Console.ReadLine());
            Console.Write("Enter Subject 3 marks: ");
            subject3Mark = int.Parse(Console.ReadLine());

            // calculate the average
            average = StudentResultCalculator.CalculateAverage(subject1Mark, subject2Mark, subject3Mark);

            // Find the result -call Business Logic
            result = StudentResultCalculator.CalculateResult(average);

            //display the result -UI
            Console.WriteLine($"Student {name} result is: {result}");
            Console.ReadLine();
        }
    }
}
