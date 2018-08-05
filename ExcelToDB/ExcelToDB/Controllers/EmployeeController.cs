using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace ExcelToDB.Controllers
{
    [RoutePrefix("api/Employee")]
    public class EmployeeController : ApiController
    {
        //DbContext  
        EmployeeEntities db = new EmployeeEntities();


        [Route("Save")]
        [HttpPost]
        [ResponseType(typeof(void))]
        public IHttpActionResult Save(List<EmployeeTable> employeeList)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            foreach (var data in employeeList)
            {
                db.EmployeeTables.Add(data);
            }
            db.SaveChanges();

            return StatusCode(HttpStatusCode.OK);

        }

    }
}