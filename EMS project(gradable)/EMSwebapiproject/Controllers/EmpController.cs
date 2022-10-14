using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.UI.WebControls;
using BLL_library;
using EMSwebapiproject.Models;
using static DAL_library.dal_class;

namespace EMSwebapiproject.Controllers
{
    public class EmpController : ApiController
    {

        bll_class log;
        public EmpController()
        {
            log = new bll_class();
        }
        // GET api/<controller>
        public List<EmpModel> Get()
        {
            var ans = log.ShowEmployeeList();
            List<EmpModel> emplist = new List<EmpModel>();
            foreach (var item in ans)
            {
                emplist.Add(new EmpModel() { empcode = item.empcode, empname = item.empname, dob = item.dob, email = item.email, deptcode = item.deptcode });
            
            }
            return emplist;
        }








        // GET api/<controller>
        /*public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }*/

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody] EmpModel value)
        {
            empprofile emp = new empprofile();
            emp.empcode = value.empcode;
            emp.empname = value.empname;
            emp.dob = value.dob;
            //emp.deptcode = value.deptcode;
            emp.email = value.email;


            log.AddEmployee(emp);
        }


        // PUT api/<controller>/5
        public void Put(int id, [FromBody] EmpModel value)
        {
            empprofile emp = new empprofile();
            emp.empcode = value.empcode;
            emp.dob = value.dob;
            emp.empname = value.empname;
            emp.deptcode = value.deptcode;
            emp.email = value.email;
            log.EditEmployee(emp);
        }
        

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            log.RemoveEmployee(id);
        }
    }
}