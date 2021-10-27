using System;
using System.Collections.Generic;
using SqrtOperation;
using Reading;
using HTMLShowing;


namespace Choices
{
    public class Choice
    {
        string Name;

        public static void Choosing()
        {
            Choice AChoice = new() { Name = "a) Read the file;", /*Sign = "a"*/ };
            Choice BChoice = new() { Name = "b) See yandex.ru;", /*Sign = "b"*/ };
            Choice CChoice = new() { Name = "c) Get a square root.", /*Sign = "c"*/ };
            List<Choice> Choices = new() { AChoice, BChoice, CChoice };

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            foreach (Choice item in Choices)
            {
                Console.WriteLine(item.Name);
            }
            Console.ResetColor();

            string outSign = null;
            do
            {
                string outSign1 = (Console.ReadLine()).ToLower();

                if (outSign1 is not "a" && outSign1 is not "b" && outSign1 is not "c")
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Please, enter an \"a\", \"b\" or \"c\".");
                    Console.ResetColor();
                }
                else outSign ??= outSign1;
            }
            while (outSign == null);

            Choice.Working(outSign);
        }

        public static void Working(string sign)
        {
            sign = sign.ToLower();
            if (sign == "a")
            {
                IReadingFile.ReadTheFile();
            }
            else if (sign == "b")
            {
                IYandex.Show();
                //await IYandex.ReadAndDisplayFilesAsync();
            }
            else if (sign == "c")
            {
                ISqrt.GetSqrt();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Please, choose one of the options: a, b or c.");
                Console.ResetColor();
            }
        }

    }

}