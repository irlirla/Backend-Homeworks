using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
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
        using (SqlConnection("server=localhost\SQLEXPRESS01; Database=master;Trusted_Connection=True;"))
        {
            sqlConnection.Open();
            [HttpGet]
            {
            }

            [HttpPost]
            {
            }

            [HttpPut]
            {
            }

            [HttpDelete]
            {
            }
}
    }
}
