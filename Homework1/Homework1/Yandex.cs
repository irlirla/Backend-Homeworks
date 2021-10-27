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

            

            //string respond = null;

            //try
            //{
                //for (int i = 0; i < text1.Length; i++)
                //{
                    using (StreamReader sr = new StreamReader(text1))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(line + ">");
                            //respond = Console.ReadLine();
                        }
                        //while (((line = sr.ReadLine()) != null) && (respond != "stop")) ;
                    }
            //    }
            ////}
            //catch (Exception e)
            //{
            //    Console.ForegroundColor = ConsoleColor.DarkRed;
            //    Console.WriteLine(e.Message.ToString());
            //    Console.WriteLine("Please try again later.");
            //    Console.ResetColor();
            //}



            //Console.WriteLine(content);

            client.Dispose();
        }
    }
}
