using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RESTapp.Controllers
{
    public class SearchController : Controller
    {
        [HttpGet("api/search/{table}")]
        public ActionResult Search(string table,string q)
        {
            string[] result = {table,q};

            return new JsonResult(result);
        }
    }
}
