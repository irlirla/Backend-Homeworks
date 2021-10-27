using System;
using Choices;

namespace Continuing
{
    interface IContinuingC
    {
        public static void ToContinue()
        {
            //Console.ForegroundColor = ConsoleColor.DarkYellow;
            //Console.WriteLine("Let's do something more?\n Please, enter \"yes\" or \"no\".");
            //Console.ResetColor();
            //string Answer = (Console.ReadLine()).ToLower();
            string Answer;
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Let's do something more?\n Please, enter \"yes\" or \"no\".");
                Console.ResetColor();
                Answer = (Console.ReadLine()).ToLower();
                if (Answer == "no" || Answer == "n")
                {
                    Console.WriteLine("It was nice to work with you! :)");
                    Console.ReadKey();
                    break;
                    //break;
                }
                else if (Answer == "yes" || Answer == "y") 
                    Choice.Choosing();
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Please, enter \"yes\" or \"no\" only.");
                    Console.ResetColor();
                    Answer = (Console.ReadLine()).ToLower();
                }
            }
            while (Answer == "yes");
        }
    }
}
