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
            var text = "Content.txt";

            using (StreamWriter sw = new StreamWriter(text, false))
            {
                await sw.WriteLineAsync(content);
            }

            var text1 = "Content1.txt";


            string[] lines = text.Split(">");

            foreach (string item in lines)
            {
                using (StreamWriter sw = new StreamWriter(text1, true))
                {
                    await sw.WriteLineAsync(item);
                }
            }





            //try
            //{
            //for (int i = 0; i < text1.Length; i++)
            //{
            //List<string> HTMLki = new List<string>();

            //using (StreamReader sr = new StreamReader(text1))
            //{
            //    string line;
            //    for (uint i = 0; i < text1.Length; i ++)
            //    {
            //        while ((line = sr.ReadLine()) != null)
            //        {
            //            HTMLki.Add(line);
            //        }
            //    }
            //            //while (((line = sr.ReadLine()) != null) && (respond != "stop")) ;
            //}

            //static async Task ReadAndDisplayFilesAsync()
            //{
            //    String filename = "Content1.txt";
            //    Char[] buffer;

            //    using (var sr = new StreamReader(filename))
            //    {
            //        buffer = new Char[(int)sr.BaseStream.Length];
            //        await sr.ReadAsync(buffer, 0, (int)sr.BaseStream.Length);
            //    }

            //    Console.WriteLine(new String(buffer) + ">");
            //}

            //string respond = null;
            //for (int i = 0; i<1000; i +=4)
            //{
            //    Console.WriteLine(buffer[i] + "\n", HTMLki[i+1] + "\n",
            //                        HTMLki[i+2] + "\n", HTMLki[i+3] + "\n");
            //    Console.WriteLine("Show the next part? To escape enter \"stop\".");
            //    respond = Console.ReadLine();
            //    if (respond == "stop") break;
            //}
            //    }
            ////}
            //catch (Exception e)
            //{
            //    Console.ForegroundColor = ConsoleColor.DarkRed;
            //    Console.WriteLine(e.Message.ToString());
            //    Console.WriteLine("Please try again later.");
            //    Console.ResetColor();
            //}

            client.Dispose();
        }

        static async Task ReadAndDisplayFilesAsync()
        {
            String filename = "Content1.txt";
            Char[] buffer;

            using (var sr = new StreamReader(filename))
            {
                buffer = new Char[(int)sr.BaseStream.Length];
                await sr.ReadAsync(buffer, 0, (int)sr.BaseStream.Length);
            }

            Console.WriteLine(new String(buffer) + ">");
        }
    }
}
