using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HomeWork2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class FilingController : ControllerBase
    {
        string text1 = @"Book.txt";

        [HttpGet]
        public string GetText()
        {
            string readText = File.ReadAllLines(text1);

        }

        [HttpPost]
        public string AddText(string str) ////где задается этот стр
        {
            using (StreamWriter sw = new StreamWriter(text1, true))
            {
                sw.WriteLine(str + "\n");
            }
        }

        [HttpDelete]
        public string DeleteText()
        {
            using (StreamWriter sw = new StreamWriter(text1, false))
            {
                sw.WriteLine("");
            }
        }

        [HttpPut]
        public string PutText(string str)
        {
            using (StreamWriter sw = new StreamWriter(text1, false))
            {
                sw.WriteLine(str);
            }
        }
    }
}
