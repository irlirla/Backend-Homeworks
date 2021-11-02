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
    public class ListingController : ControllerBase
    {
        List<Users> users = new List<Users>();

        public ListingController()
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
        }

        [HttpPost]
        public void Post(Users info)
        {
            users.Add(info);
        }

        [HttpPost(File)]
        public void Post([FromBody] FileDto model)
        {
            
        }

        [HttpDelete]
        public void Delete(int id)
        {
            users.Remove(x => { x.Id = id});
        }

        [HttpPut]
        {
            
        }
    }
