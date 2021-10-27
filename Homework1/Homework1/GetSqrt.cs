using System;
using Continuing;

namespace SqrtOperation
{
    interface ISqrt
    {
        public static void GetSqrt()
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
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Can't make this operation! Please, enter a positive number.");
                        Console.ResetColor();
                    }
                }
                while (sqrtNumber == -1);

            }
            catch (FormatException e)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("An Error Occured. Please restart and enter a number(!).");
                Console.WriteLine(e.Message.ToString());
                Console.ResetColor();
            }
            catch (OverflowException e)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Sorry, for now we're working only with numbers in range:\nfrom {double.MinValue} to {double.MaxValue}.\nPlease restart and try another number.");
                Console.WriteLine(e.Message.ToString());
                Console.ResetColor();
            }

            IContinuingC.ToContinue();
        }
    }
}
