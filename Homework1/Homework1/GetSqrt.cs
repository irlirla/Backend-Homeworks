using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqrtOperation
{
    public class Sqrt
    {
        public void GetSqrt()
        {
            Console.WriteLine("Okay, let's get this root!");
            Console.WriteLine("Please, enter a positive number for a sqrt operation.");
            double sqrtNumber = -1;
            try
            {
                do
                {
                    double number = Convert.ToDouble(Console.ReadLine());
                    if (number >= 0)
                    {
                        sqrtNumber = Math.Sqrt(number);
                        Console.WriteLine($"Square root out of {number} is {sqrtNumber}.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Can't make this operation! Please, enter a positive number.", 
                            Console.ForegroundColor = ConsoleColor.DarkRed);
                        Console.ResetColor();
                    }
                }
                while (sqrtNumber == -1);

            }
            catch (FormatException)
            {
                Console.WriteLine("An Error Occured. Please restart and enter a number(!).",
                    Console.ForegroundColor = ConsoleColor.DarkRed);
                Console.ResetColor();
            }
            catch (OverflowException)
            {
                Console.WriteLine($"Sorry, for now we're working only with numbers in range:\nfrom {double.MinValue} to {double.MaxValue}.\nPlease restart and try another number.",
                    Console.ForegroundColor = ConsoleColor.DarkRed);
                Console.ResetColor();
            }
        }
    }
}
