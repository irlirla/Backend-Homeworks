using System;
using Choices;
using Continuing;

namespace HomeWork1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello there! What're we going to do?");
            Choice userChoice = new();
            userChoice.Choosing();

            ContinuingC cont = new();
            cont.ToContinue();

        }
    }
}