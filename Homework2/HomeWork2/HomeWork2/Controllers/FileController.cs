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
    public class FileController : ControllerBase
    {
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }

    public class FilingController : ControllerBase
    {
        string text1 = @"Book.txt";

        [HttpGet]
        public string GetText()
        {
            return string readText = File.ReadAllLines(text1);
        }

        [HttpPost]
        public void AddText(string str) ////где задается этот стр
        {
            using (StreamWriter sw = new StreamWriter(text1, true))
            {
                sw.WriteLine(str + "\n");
            }
        }

        [HttpDelete]
        public void DeleteText()
        {
            using (StreamWriter sw = new StreamWriter(text1, false))
            {
                sw.WriteLine("");
            }
        }

        [HttpPut]
        public void PutText(string str)
        {
            using (StreamWriter sw = new StreamWriter(text1, false))
            {
                sw.WriteLine(str);
            }
        }
    }
}
