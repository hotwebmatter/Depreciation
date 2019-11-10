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
            WriteLine(GenerateHeader());
            Vehicle aCar = new Vehicle("mustang", 25000);
            WriteLine("Model of car is {0}", aCar.Name);
            WriteLine("Value of car is {0:c}", aCar.Worth);
            aCar.CalculateDepreciation();
            WriteLine("New value of car is {0:c}", aCar.Worth);
        }

        static string GenerateHeader()
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
