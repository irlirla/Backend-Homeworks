using System;
using Choices;

namespace Continuing
{
    public class ContinuingC
    {
        public void ToContinue()
        {
            Choice userChoice = new();
            Console.WriteLine("Let's do something more?\n Please, enter \"yes\" or \"no\".",
               Console.ForegroundColor = ConsoleColor.DarkYellow);
            Console.ResetColor();
            string Answer = (Console.ReadLine()).ToLower();
            do
            {
                if (Answer == "no")
                {
                    Console.WriteLine("It was nice to work with you! :)");
                    Console.ReadKey();
                }
                else if (Answer == "yes") userChoice.Choosing();
                else
                {
                    Console.WriteLine("Please, enter \"yes\" or \"no\" only.",
                        Console.ForegroundColor = ConsoleColor.DarkRed);
                    Console.ResetColor();
                    Answer = (Console.ReadLine()).ToLower();
                }
            }
            while (Answer is "yes");
        }
    }
}
