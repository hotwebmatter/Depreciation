/**
 * ######################################################
 * ##    Programming Assignment #10                    ##
 * ##    Developer: Matthew Obert                      ##
 * ##    Date Submitted: November 10 2019              ##
 * ##    Purpose: Demonstrate usage of for loops       ##
 * ######################################################
 */
 
using System;
using static System.Console;

namespace Depreciation
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputValue;
            double number;
            WriteLine(GenerateHeader());
            Vehicle aCar = new Vehicle();
            Write("Enter car or -99 to quit: ");
            inputValue = ReadLine();
            while (inputValue != "-99")
            {
                aCar.Name = inputValue;
                // Set up the nested loop with prime read
                // It's OK to reuse the inputValue string
                Write("Enter car value: ");
                inputValue = ReadLine();
                while (double.TryParse(inputValue, out number) == false)
                {
                    // Invalid Input
                    Write("Invalid input. Enter car value: ");
                    inputValue = ReadLine();
                }
                aCar.Worth = number;

                // set up the for loop
                for (int i = 0; i < 5; i++)
                {
                    aCar.CalculateDepreciation();
                    WriteLine("\tYear {0} value {1:c}\n", i + 1, aCar.Worth);
                }
            }
        }

        private static string GenerateHeader()
        {
            string result = string.Format("\tDepreciation\n");
            result += string.Format("\tCalculate depreciation of a car\n");
            result += string.Format("\tMatthew Obert\n");
            result += string.Format("\tNovember 10 2019\n");
            result += string.Format("**************************************************\n");
            result += string.Format("This program will calculate depreciation\n\tfor a five year period.\n");
            result += string.Format("You will be asked to enter make of the car\n\tor -99 to quit.\n");
            result += string.Format("You will be asked to enter the value of the car.\n\n");
            result += string.Format("**************************************************\n");
            return result;
        }
    }
}
