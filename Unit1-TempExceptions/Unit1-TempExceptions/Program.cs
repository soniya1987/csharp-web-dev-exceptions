using System;

//Book examples for the Unit 1 C# Program

namespace Unit1_TempExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a Fahrenheit temperature value");
            string inputValue = Console.ReadLine();
            double inputTemp = Double.Parse(inputValue);

            try
            {
                Temperature userTemp = new Temperature(inputTemp);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
        }
    }
}