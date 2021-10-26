using System;
using System.Collections.Generic;


namespace HomeWork1
{
    public class Choice
    {
        string Name;
        string Sign;

        public void Choosing()
        {
            Choice AChoice = new() { Name = "a) Read the file;", Sign = "a" };
            Choice BChoice = new() { Name = "b) See yandex.ru;", Sign = "b" };
            Choice CChoice = new() { Name = "c) Get a square root.", Sign = "c" };
            List<Choice> Choices = new() { AChoice, BChoice, CChoice };
            foreach (Choice item in Choices)
            {
                Console.WriteLine(item.Name);
            }
            string outSign = (Console.ReadLine()).ToLower(); ///////????????????

            if (outSign.Length is 1)
            {
                if (outSign is not "a" && outSign is not "b" && outSign is not "c")
                {
                    Console.WriteLine("Please, enter an \"a\", \"b\" or \"c\".");
                }

            }

            Choice userChoice = new();
            userChoice.Working(outSign);
        }
        public void Working(string sign)
        {
            sign = sign.ToLower(); //??????????????????????????????????////
            if (sign == "a")
            {
                Console.WriteLine("Okay, let's read this file! Where is it located?");
                string address = Console.ReadLine();

                //try
                //{

                //}
            }
            else if (sign == "b")
            {
                Console.WriteLine("Okay, let's watch some yandex!");

                Console.WriteLine("Wanna see what's next?");
            }
            else if (sign == "c")
            {
                Console.WriteLine("Okay, let's get this root!");
                Sqrt sqrt = new();
                sqrt.GetSqrt();
            }
            else
            {
                Console.WriteLine("Please, choose one of the options: a, b or c.");
            }
        }

    }
}