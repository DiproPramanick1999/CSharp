using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XYZUniversity.ResuktCalculator;
using XYZUniversity.Entities;


namespace CalculateResultStudConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            double average;
            

            //input- UI Logic
            Console.Write("Enter the name of the student:");
            student.studentName=Console.ReadLine();

            Console.Write("Enter Subject 1 marks: ");
            student.SetMarks1(int.Parse(Console.ReadLine()));

            Console.Write("Enter Subject 2 marks: ");
            student.SetMarks2(int.Parse(Console.ReadLine()));

            Console.Write("Enter Subject 3 marks: ");
            student.SetMarks3(int.Parse(Console.ReadLine()));

            // calculate the average
            average = StudentResultCalculator.CalculateAverage(student.GetMarks1(),student.GetMarks2(),student.GetMarks3());

            // Find the result -call Business Logic
            student.result = StudentResultCalculator.CalculateResult(average);

            //display the result -UI
            Console.WriteLine($"Student {student.studentName} result is: {student.result}");
            Console.ReadLine();
        }
    }
}
