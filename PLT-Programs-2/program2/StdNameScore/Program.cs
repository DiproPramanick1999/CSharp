using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StdNameScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int no, avg = 0;
            Console.Write("Number of students: ");
            no = int.Parse(Console.ReadLine());
            string[] str = new string[no];
            int[] studentTotal = new int[no];
            for (int i = 0; i < no; i++)
            {
                string name;
                Console.Write("Enter the name of the student:");
                name = Console.ReadLine();
                string[] scores = new string[3];
                int sum = 0;
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"Enter the {j + 1} subject marks: ");
                    scores[j] = Console.ReadLine();
                    sum += int.Parse(scores[j]);
                }
                Console.WriteLine(name + " has scored total " + sum);
                avg = sum / 3;
                studentTotal[i] = avg;
            }
            int largest = -1;
            int second = 0;
            int total = 0;
            foreach (int i in studentTotal)
            {
                total += i;
                if (i > largest)
                {
                    second = largest;
                    largest = i;
                }
                else if (i > second)
                    second = i;
            }
            Console.WriteLine($"The first largest: {largest} and The Second largest: {second}");
            Console.WriteLine($"The Average is: {total / (studentTotal.Length)}");
            for (int i = 0; i < no; i++)
            {

                if (studentTotal[i] >= 60)
                    Console.WriteLine($"Student {i + 1} is 1st pass");
                else if (studentTotal[i] >= 50)
                    Console.WriteLine($"Student {i + 1} is 2st pass");
                else if (studentTotal[i] >= 35)
                    Console.WriteLine($"Student {i + 1} is pass");
                else
                    Console.WriteLine($"Student {i + 1} is fail");
            }
            Console.ReadLine();

        }
    }
}
