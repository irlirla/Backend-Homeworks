using System;
using System.IO;

namespace Reading
{
    class ReadingFile
    {
        public void ReadTheFile()
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
                Console.WriteLine("The file could not be read:", Console.ForegroundColor = ConsoleColor.DarkRed);
                Console.WriteLine(e.Message.ToString(), Console.ForegroundColor = ConsoleColor.DarkRed);
                Console.ResetColor();
            }
        }
    }
}
