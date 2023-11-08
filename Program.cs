using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
                // Example using TryParse to convert a string to an integer
                string intStr = "123";
                if (int.TryParse(intStr, out int intResult))
                {
                    Console.WriteLine($"TryParse: Successfully converted '{intStr}' to int: {intResult}");
                }
                else
                {
                    Console.WriteLine($"TryParse: Failed to convert '{intStr}' to int.");
                }

                // Example using Convert to convert a string to a double
                string doubleStr = "45.67";
                try
                {
                    double doubleResult = Convert.ToDouble(doubleStr);
                    Console.WriteLine($"Convert: Successfully converted '{doubleStr}' to double: {doubleResult}");
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Convert: Format exception occurred while converting '{doubleStr}' to double.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"Convert: Overflow exception occurred while converting '{doubleStr}' to double.");
                }

                // Example using Parse to convert a string to a decimal
                string decimalStr = "78.90";
                try
                {
                    decimal decimalResult = decimal.Parse(decimalStr);
                    Console.WriteLine($"Parse: Successfully converted '{decimalStr}' to decimal: {decimalResult}");
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Parse: Format exception occurred while converting '{decimalStr}' to decimal.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"Parse: Overflow exception occurred while converting '{decimalStr}' to decimal.");
                }

                // Test cases with invalid input
                string invalidStr = "invalidInput";

                if (int.TryParse(invalidStr, out int _))
                {
                    Console.WriteLine("TryParse: Successfully converted invalid input to int.");
                }
                else
                {
                    Console.WriteLine("TryParse: Failed to convert invalid input to int.");
                }

                try
                {
                    double invalidResult = Convert.ToDouble(invalidStr);
                    Console.WriteLine($"Convert: Successfully converted invalid input to double: {invalidResult}");
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Convert: Format exception occurred while converting invalid input to double.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"Convert: Overflow exception occurred while converting invalid input to double.");
                }

                try
                {
                    decimal invalidResult = decimal.Parse(invalidStr);
                    Console.WriteLine($"Parse: Successfully converted invalid input to decimal: {invalidResult}");
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Parse: Format exception occurred while converting invalid input to decimal.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"Parse: Overflow exception occurred while converting invalid input to decimal.");
                }
            Console.ReadKey();
            }
        }

    }

