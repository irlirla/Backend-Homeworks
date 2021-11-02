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
<<<<<<< Updated upstream:Homework2/HomeWork2/HomeWork2/Controllers/FileController.cs
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
=======
        public List<Users> GetAll()
        {
            return users;
           /* if (response.StatusCode == HttpStatusCode.OK)
                return "Update completed";
            else
                return "Error";
           */
        }

        [HttpGet]
        public List<Users> Get(int id)
        {
            return users.(x => x.Id = id);
          /*  if (response.StatusCode == HttpStatusCode.OK)
                return "Update completed";
            else
                return "Error";
          */
>>>>>>> Stashed changes:Homework2/HomeWork2/HomeWork2/Controllers/Controller.cs
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

<<<<<<< Updated upstream:Homework2/HomeWork2/HomeWork2/Controllers/FileController.cs
        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
=======
        [HttpPost(File)]
        public string Post([FromBody] FileDto model)
>>>>>>> main
        {
            
        }

        [HttpDelete]
        public string Delete(int id)
>>>>>>> Stashed changes:Homework2/HomeWork2/HomeWork2/Controllers/Controller.cs
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

<<<<<<< Updated upstream:Homework2/HomeWork2/HomeWork2/Controllers/FileController.cs
        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
=======
        [HttpPatch]
        public string PatchName(int id, string str)
        {
             str = "";
             id = ;
             users.(x => x.Id = id).Name = str;
             if (response.StatusCode == HttpStatusCode.OK)
                return "Update completed";
            else
                return "Error";
>>>>>>> Stashed changes:Homework2/HomeWork2/HomeWork2/Controllers/Controller.cs
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
