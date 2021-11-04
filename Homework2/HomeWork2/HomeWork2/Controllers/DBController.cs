using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Data;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HomeWork2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DBController : ControllerBase
    {
        SqlConnection connection = new SqlConnection(@"server=localhost\SQLEXPRESS01; Database=master;Trusted_Connection=True;");

            [HttpGet]
            public string Get()
            {
            SqlDataAdapter da = new SqlDataAdapter("select Heroes.ID, [First Name], [Second Name], [Dumbledore's Army], Faculties.Faculty " +
                "from HPCharacters.dbo.Heroes" +
                "inner join HPCharacters.dbo.Faculties on Heroes.Faculty = Faculties.ID", connection);
            DataTable dt = new DataTable();

            da.Fill(dt);
            if (dt.Rows.Count > 0)  //Any?
            {
                return JsonConvert.SerializeObject(dt);
            }
            else
            {
                return "The table is empty.";
            }

            }

        [HttpGet(Getbyid)]
        public string Get(int ID)
        {
            SqlDataAdapter da = new SqlDataAdapter("select Heroes.ID, [First Name], [Second Name], [Dumbledore's Army], Faculties.Faculty " +
               "from HPCharacters.dbo.Heroes" +
               "inner join HPCharacters.dbo.Faculties on Heroes.Faculty = Faculties.ID" +
               $"where Heroes.ID ={ID}", connection);
            DataTable dt = new DataTable();

            da.Fill(dt);
            if (dt.Rows.Count > 0)  //Any?
            {
                return JsonConvert.SerializeObject(dt);
            }
            else
            {
                return "No such Hero found.";
            }
        }

            [HttpPost]
            public string Post(int ID, int Fac, int Army, [FromBody] string FirstName, string SecondName)
            {
            SqlCommand cmd = new SqlCommand($"insert into HPCharacters.dbo.Heroes values ('{ID}', '{FirstName}', '{SecondName}', '{Fac}', '{Army}')");
            connection.Open();
            int i = cmd.ExecuteNonQuery();
            connection.Close();
            if (i == 1)
            {
                return "This Hero was uploaded successfully";
            }
            else
            {
                return "Please, try again. No Hero inserted.";
            }
            }

            [HttpPut]
            public string Put(int id, [FromBody] string ChangingSpec, string value)
            {
            SqlCommand cmd = new SqlCommand($"Update HPCharacters.dbo.Heroes set [{ChangingSpec}] = {value} where Heroes.ID = {id}", connection);
            connection.Open();
            int i = cmd.ExecuteNonQuery();
            connection.Close();
            if (i == 1)
            {
                return "This Hero was edited successfully";
            }
            else
            {
                return "Please, try again. No Hero edited.";
            }
        }

            [HttpDelete]
            public string Delete(int id)
            {
            SqlCommand cmd = new SqlCommand($"Delete from HPCharacters.dbo.Heroes where Heroes.ID = {id}", connection);
            connection.Open();
            int i = cmd.ExecuteNonQuery();
            connection.Close();
            if (i == 1)
            {
                return "This Hero was deleted successfully";
            }
            else
            {
                return "Please, try again. No Hero deleted.";
            }
        }
}
    }
}
