using System;
using System.IO;
using Continuing;

namespace Reading
{
    interface IReadingFile
    {
        public static void ReadTheFile()
        {
            Console.WriteLine("Okay, let's read this file! Where is it located?");
            string address = Console.ReadLine();

            try
            {
                using (StreamReader sr = new StreamReader(address))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message.ToString());
                Console.WriteLine("Please try again later.");
                Console.ResetColor();
            }

            IContinuingC.ToContinue();
        }
    }
}
