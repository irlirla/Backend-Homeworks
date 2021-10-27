using System;
using Choices;

namespace HomeWork1
{
    class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Hello there! What're we gonna do?");
            Console.ResetColor();

            Choice.Choosing();

            Console.ReadKey();
        }
    }
}