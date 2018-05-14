using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RESTapp.Controllers
{
    public class ConfigureController : Controller
    {

        [HttpGet("api/configure/{table}")]
        public ActionResult GetSchema(string table)
        {
            return new JsonResult("The schema for the table");
        }
        [HttpPut("api/configure/{table}")]
        public ActionResult ConfigureTable(string table)
        {
            return new JsonResult("Update the table");
        }
        [HttpPost("api/configure/newtable")]
        public ActionResult NewTable()
        {
            return new JsonResult("New table");
        }
    }
}
