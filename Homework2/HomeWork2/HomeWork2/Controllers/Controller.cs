using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace HomeWork2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FirstController : ControllerBase
    {
        List<Users> users = new List<Users>;

        var response =  (HttpWebResponse) request.GetResponse();

        public FirstController()
        { 
            users.Add(new Users {Id = 1, Name = "Bilbo", Age = 35, Address = "Middle-earth"});
            users.Add(new Users {Id = 2, Name = "Frodo", Age = 22, Address = "Mordor"});
            users.Add(new Users {Id = 3, Name = "Samwise", Age = 27, Address = "Shire"});
            users.Add(new Users {Id = 4, Name = "Peregrin", Age = 18, Address = "Shire"});
            users.Add(new Users {Id = 5, Name = "Legolas", Age = 115, Address = "Gondor"});
        }

        [HttpGet]
        public List<Users> Get()
        {
            return users;
            if (response.StatusCode == HttpStatusCode.OK)
                return "Update completed";
            else
                return "Error";
        }

        [HttpPost]
        public string Post(Users info)
        {
            users.Add(info);

            if (response.StatusCode == HttpStatusCode.Created)
                return "Update completed";
            else
                return "Error";
        }

        [HttpPost(File)]
        public string Post([FromBody] FileDto model)
        {
            
        }

        [HttpDelete]
        public void Delete(int id)
        {
            users.Remove(x => x.Id = id);
             if (response.StatusCode == HttpStatusCode.NoContent)
                return "Update completed";
            else
                return "Error";
        }

        [HttpPut]
        {
            
        }

        [HttpPatch]
        public void PatchName(int id, string str)
        {
             if (response.StatusCode == HttpStatusCode.OK)
                return "Update completed";
            else
                return "Error";
        }
    }

 public class SecondController : ControllerBase
    {
        string text1 = @"C:\Lanit\Homeworks\Homework1\Backend-Homeworks\Homework2\Book.txt";

        var response =  (HttpWebResponse) request.GetResponse();

        [HttpGet]
        public string GetText()
        {
            return string readText = File.ReadAllLines(text1);
            if (response.StatusCode == HttpStatusCode.OK)
                return "Update completed";
            else
                return "Error";
        }

        [HttpPost]
        public void AddText(string str) ////где задается этот стр
        {
            using (StreamWriter sw = new StreamWriter(text1, true))
                    {
                        sw.WriteLine(str + "\n");
                    }
             if (response.StatusCode == HttpStatusCode.Created)
                return "Update completed";
            else
                return "Error";
        }

        [HttpDelete]
        public void DeleteText()
        {
            using (StreamWriter sw = new StreamWriter(text1, false))
                    {
                        sw.WriteLine("");
                    }
             if (response.StatusCode == HttpStatusCode.NoContent)
                return "Update completed";
            else
                return "Error";
        }

        [HttpPut]
        public void PutText(string str)
        {
            using (StreamWriter sw = new StreamWriter(text1, false))
                    {
                        sw.WriteLine(str);
                    }
             if (response.StatusCode == HttpStatusCode.OK)
                return "Update completed";
            else
                return "Error";
        }
}
