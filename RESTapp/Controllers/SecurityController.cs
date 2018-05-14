using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RESTapp.Controllers
{
    public class SecurityController : Controller
    {
        [HttpGet("api/security/acl/{table}")]
        public ActionResult ListTableACL(string table)
        {
            string[] result = {table};
            return new JsonResult(result);
        }

        [HttpGet("api/security/users")]
        public ActionResult UserRecords()
        {
            return new JsonResult("");
        }

        [HttpGet("api/security/userroles/{userid}")]
        public ActionResult ListUserRoles(int userid)
        {
            return new JsonResult("");
        }
        
        [HttpGet("api/security/roles")]
        public ActionResult ListRoles()
        {
            return new JsonResult("");
        }
    }
}
