using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYZUniversity.ResuktCalculator
{
    public class StudentResultCalculator
    {
        public static double CalculateAverage(params int[] subjectMarks)
        {
            // calculate the average
            //int totalMarks = 0;
            //foreach (int mark in subjectMarks)
            //{
            //    totalMarks += mark;
            //}
            //double average = totalMarks / subjectMarks.Length;
            //return average;
            return subjectMarks.Average();
        }

        public static string CalculateResult(double average)
        {

            if (average >= 60)
                return "First Class";
            else if (average >= 49)
                return "Second Class";
            else if (average >= 35)
                return "Pass Class";
            else
                return "Fail";
        }
    }
}

