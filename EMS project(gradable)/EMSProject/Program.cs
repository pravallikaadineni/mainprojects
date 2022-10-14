using BLL_library;
using DAL_library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DAL_library.dal_class;

namespace EMSProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*  MyContext context = new MyContext();
          context.depttable.Add(new deptmaster { deptcode = 1, deptname = "ECE" });
          context.depttable.Add(new deptmaster { deptcode = 2, deptname = "CSE" });
          context.depttable.Add(new deptmaster { deptcode = 3, deptname = "EEE" });
          context.depttable.Add(new deptmaster { deptcode = 4, deptname = "MECH" });
          context.depttable.Add(new deptmaster { deptcode = 5, deptname = "CIVIL" });


          context.emptable.Add(new empprofile { empcode = 1, empname = "Amit", email = "amit@123", dob = new DateTime(2022, 11, 11),deptcode=1 });
          context.emptable.Add(new empprofile { empcode = 2, empname = "nani", email = "nani@123", dob = new DateTime(2011, 10, 11), deptcode = 2 });
          context.emptable.Add(new empprofile { empcode = 3, empname = "sweety", email ="sweety@123", dob = new DateTime(2012, 10, 11), deptcode = 3 });
          context.emptable.Add(new empprofile { empcode = 4, empname = "jenny", email = "jenny@123", dob = new DateTime(2013, 05, 4), deptcode = 4 });
          context.emptable.Add(new empprofile { empcode = 5, empname = "jack", email = "jack@123", dob = new DateTime(2014, 08, 6), deptcode = 5 });
          context.SaveChanges();
          Console.WriteLine("done");*/


            bll_class co = new bll_class();
            List<empprofile> employees = co.ShowEmployeeList();

            foreach (var item in employees)
            {
                Console.WriteLine(item.empcode + " " + item.empname + " " + item.dob + " " + item.email + " " + item.deptcode);
            }

            Console.WriteLine("=---------------------------");
            empprofile bal = new empprofile();
            Console.WriteLine("Update Employee");
            Console.WriteLine("enter empcode to update");
            bal.empcode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter empname");
            bal.empname = Console.ReadLine();
            Console.WriteLine("enter dob");
            bal.dob = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("enter email");
            bal.email = Console.ReadLine();
            Console.WriteLine("enter deptcode ");
            bal.deptcode = Convert.ToInt32(Console.ReadLine());
            co.EditEmployee(bal);
            Console.WriteLine("Updated successfully");
            Console.WriteLine("------------------------------");


            Console.WriteLine("Add employee");
            Console.WriteLine("enter empcode");

            bal.empcode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter empname");
            bal.empname = Console.ReadLine();

            Console.WriteLine("enter email");
            bal.email = Console.ReadLine();
            Console.WriteLine("enter deptcode");

            bal.deptcode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter dob");

            bal.dob = Convert.ToDateTime(Console.ReadLine());

            co.AddEmployee(bal);
            Console.WriteLine("Added successfully");

            Console.ReadLine();

            Console.WriteLine("Delete employee using empcode");
            Console.WriteLine("enter empcode to delete");
            int empcode = Convert.ToInt32(Console.ReadLine());
            co.RemoveEmployee(empcode);
            Console.WriteLine("Deleted successfully....");
            Console.ReadLine();
        }
    }
}