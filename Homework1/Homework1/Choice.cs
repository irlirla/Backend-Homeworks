using System;
using System.Collections.Generic;
using SqrtOperation;
using Reading;


namespace Choices
{
    public class Choice
    {
        string Name;
        //string Sign;

        public void Choosing()
        {
            Choice AChoice = new() { Name = "a) Read the file;", /*Sign = "a"*/ };
            Choice BChoice = new() { Name = "b) See yandex.ru;", /*Sign = "b"*/ };
            Choice CChoice = new() { Name = "c) Get a square root.", /*Sign = "c"*/ };
            List<Choice> Choices = new() { AChoice, BChoice, CChoice };
            foreach (Choice item in Choices)
            {
                Console.WriteLine(item.Name);
            }
            string outSign = null;
            do
            {
                string outSign1 = (Console.ReadLine()).ToLower();

                if (outSign1 is not "a" && outSign1 is not "b" && outSign1 is not "c")
                {
                    Console.WriteLine("Please, enter an \"a\", \"b\" or \"c\".", ConsoleColor.DarkRed);
                }
                else outSign ??= outSign1;
            }
            while (outSign == null);

            Choice userChoice = new();
            userChoice.Working(outSign);
        }
        public void Working(string sign)
        {
            sign = sign.ToLower(); //??????????????????????????????????////
            if (sign == "a")
            {
                ReadingFile rf = new();
                rf.ReadTheFile();
            }
            else if (sign == "b")
            {
                Console.WriteLine("Okay, let's watch some yandex!");

                Console.WriteLine("Wanna see what's next?");
            }
            else if (sign == "c")
            {
                Sqrt sqrt = new();
                sqrt.GetSqrt();
            }
            else
            {
                Console.WriteLine("Please, choose one of the options: a, b or c.", ConsoleColor.DarkRed);
            }
        }

    }

}