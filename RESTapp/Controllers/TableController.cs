using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RESTapp.Controllers
{
    public class TableController : Controller
    {

        [HttpGet("api/table/{table}/{id}")]
        public ActionResult GetRecord(string table,string id)
        {
            return new JsonResult(string.Format("The full table {0} {1}",table,id));
        }

        [HttpPost("api/table/{table}")]
        public ActionResult CreateRecord(string table,dynamic newRecordConents)
        {
            return new JsonResult(newRecordConents);
        }
        [HttpPut("api/table/{table}")]
        public ActionResult UpdateRecord(string table, dynamic newRecordConents)
        {
            return new JsonResult(newRecordConents);
        }



    }
}