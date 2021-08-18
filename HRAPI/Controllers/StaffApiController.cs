using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HRAPI_Model;
using Staff_BL;

namespace HRAPI.Controllers
{
    public class StaffApiController : ApiController
    {
        [HttpPost]
        [ActionName("GetStaffLogin")]
        public IHttpActionResult GetProject([FromBody] StaffModel staffModel)
        {
            StaffBL projectBL = new StaffBL();
            return Ok(projectBL.GetStaffLogin(staffModel));
        }

        [HttpGet]
        [ActionName("GetValue")]
        // GET api/<controller>/5
        public string GetValue()
        {
            return "Kyaw Thet";
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}