using System;
using Continuing;
using System.Net.Http;
using System.IO;


namespace HTMLShowing
{
    interface IYandex
    {
        static void Show()
        {
            Console.WriteLine("Okay, let's read some yandex!\nTo stop showing the page enter \"stop\".");

            var text = @"Content.txt";
            var text1 = @"Content1.txt";

            Console.WriteLine("Making API Call...");
            using (var client = new HttpClient(new HttpClientHandler { }))
            {
                client.BaseAddress = new Uri("https://yandex.ru");

                HttpResponseMessage response = client.GetAsync("").Result;
                string result = response.Content.ReadAsStringAsync().Result;
                using (StreamWriter sw = new StreamWriter(text, false))
                {
                    sw.WriteLine(result.ToString());
                }

                string[] lines = result.Split(">;");

                foreach (string item in lines)
                {
                    using (StreamWriter sw = new StreamWriter(text1, true))
                    {
                        sw.WriteLine(item + "\n");
                    }
                }

            }
            string[] readText = File.ReadAllLines(text1);
            try
            {
                for (int i = 0; i < 100000; i += 4)
                {
                    Console.WriteLine(readText[i] + ">\n" + readText[i + 1] + ">\n" + readText[i + 2] + ">\n" + readText[i + 3] + ">\n");
                    Console.WriteLine("Show next block?");

                    if (Console.ReadLine() == "stop")
                    {
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(e.Message.ToString());
                Console.WriteLine("Please try again later.");
                Console.ResetColor();
            }

            IContinuingC.ToContinue();
        }
    }
}
