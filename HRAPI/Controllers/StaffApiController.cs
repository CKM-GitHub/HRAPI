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
        public IHttpActionResult GetStaffLogin([FromBody] StaffModel staffModel)
        {
            StaffBL staffBL = new StaffBL();
            Crypto crypto = new Crypto();
            staffModel.Password = crypto.Encrypt(staffModel.Password, "forever_arsenal");
            return Ok(staffBL.GetStaffLogin(staffModel));
        }

        [HttpPost]
        [ActionName("GetStaffList")]
        public IHttpActionResult GetStaffList([FromBody] StaffModel staffModel)
        {
            StaffBL staffBL = new StaffBL();
            return Ok(staffBL.GetStaffList(staffModel));
        }

        [HttpGet]
        [ActionName("GetValue")]
        // GET api/<controller>/5
        public string GetValue()
        {
            StaffBL projectBL = new StaffBL();
            Crypto crypto = new Crypto();
            string s1 = crypto.Encrypt("12345", "forever_arsenal");
            return s1;
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