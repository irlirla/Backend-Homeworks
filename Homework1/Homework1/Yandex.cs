using System;
using Continuing;
using System.Net.Http;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;


namespace HTMLShowing
{
    interface IYandex
    {
        static async Task Show()
        {
            Console.WriteLine("Okay, let's read some yandex!\nTo stop showing the page enter \"stop\".");

            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("User-Agent", "C# console program");

            var content = await client.GetStringAsync("http://yandex.ru");

            var text = @"Content.txt";

            using (StreamWriter sw = new StreamWriter(text, false))
            {
                await sw.WriteLineAsync(content.ToString());
            }

            var text1 = @"Content1.txt";


            string[] lines = text.Split(">;");

            foreach (string item in lines)
            {
                using (StreamWriter sw = new StreamWriter(text1, true))
                {
                    await sw.WriteLineAsync(item + "\n");
                }
            }


            string[] readText = File.ReadAllLines(text1);
            try
            {
                for (int i = 0; i < readText.Length; i += 4)
                {

                    Console.WriteLine(readText[i] + ">\n" + readText[i + 1] + ">\n" + readText[i + 2] + ">\n" + readText[i + 3] + ">\n");
                    Console.WriteLine("Show next block?");
                    string respond = Console.ReadLine();
                    if (respond == "stop") break;
                    else continue;

                }
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(e.Message.ToString());
                Console.WriteLine("Please try again later.");
                Console.ResetColor();
            }

            client.Dispose();

        }
    }
}
