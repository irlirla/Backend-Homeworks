using System;

namespace HomeWork1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello there! What're we going to do?");
            Choice userChoice = new();
            userChoice.Choosing();


            Console.WriteLine("Let's do something more?\n Please, enter \"yes\" or \"no\".");
            string Answer = Console.ReadLine();
            if (Answer == "no")
            {
                Console.WriteLine("It was nice to work with you! :)");
                Console.ReadKey();
            }
            else if (Answer == "yes") userChoice.Choosing();

        }
    }
}