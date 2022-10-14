using DAL_library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DAL_library.dal_class;



namespace BLL_library
{
    public class bll_class
    {
        operations dal = null;
        public bll_class()
        {
            dal = new operations();
        }
        public List<empprofile> ShowEmployeeList()
        {
            return dal.GetEmployees();
        }
        public void AddEmployee(empprofile bal)
        {
            dal.Insertemployee(bal);

        }
        public void EditEmployee(empprofile bal)
        {
            dal.UpdateEmployee(bal);
        }
        public void RemoveEmployee(int empcode)
        {
            dal.DeleteEmployee(empcode);
        }
    }
}

