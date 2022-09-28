using System;
using System.Collections.Generic;

//Exercises for the Exceptions Chapter

namespace csharp_web_dev_lsn9exceptions
{
    class Program
    {
        
        static double Divide(double x, double y)
        {
            // Write your code here!
            if (y == 0)
            {
                throw new DivideByZeroException("y value cannot be 0");
            }

            return x / y;
        }

        static int CheckFileExtension(string fileName)
        {
            // Write your code here!
            if (string.IsNullOrEmpty(fileName))
            {
                throw new NullReferenceException("fileName should not be null or empty");
            }
            else if (fileName.Substring(fileName.Length - 3, 3) == ".cs")
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        

        static void Main(string[] args)
        {
            // Test out your Divide() function here!
            try
            {
                Divide(1.0, 0);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.ToString());
            }

            // Test out your CheckFileExtension() function here!
            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.cs");

            foreach (KeyValuePair<string, string> item in students)
            {
                try
                {
                    Console.WriteLine(CheckFileExtension(item.Value));
                }
                catch (NullReferenceException ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }

        }
    }
}
