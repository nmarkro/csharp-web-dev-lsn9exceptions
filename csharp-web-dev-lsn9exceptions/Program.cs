using System;
using System.Collections.Generic;
using System.IO;

namespace csharp_web_dev_lsn9exceptions
{
    class Program
    {
        static double Divide(double x, double y)
        {
            if (y == 0.0)
            {
                throw new ArgumentOutOfRangeException("Cannot divide by 0");
            }
            return x / y;
        }

        static int CheckFileExtension(string fileName)
        {
            if (fileName == null)
            {
                throw new ArgumentNullException("fileName cannot be null");
            } else if (fileName == "")
            {
                throw new ArgumentException("fileName cannot be an empty string");
            }
            return fileName.ToLower().EndsWith(".cs") ? 1 : 0;
        }


        static void Main(string[] args)
        {
            Console.Write("Input Numerator: ");
            double numerator = double.Parse(Console.ReadLine());
            Console.Write("Input Denominator: ");
            double denominator = double.Parse(Console.ReadLine());

            try
            {
                Console.WriteLine("Answer: " + Divide(numerator, denominator));
            } catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Error: cannot divide by 0");
            }
            Console.WriteLine();

            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.cs");

            foreach (KeyValuePair<string, string> student in students)
            {
                try
                {
                    Console.WriteLine(student.Key + "\'s score is " + CheckFileExtension(student.Value));
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error with " + student.Key + "\'s input: " + e.Message);
                }
            }
        }
    }
}
