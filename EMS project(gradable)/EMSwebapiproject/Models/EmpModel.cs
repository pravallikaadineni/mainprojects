using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EMSwebapiproject.Models
{
    public class EmpModel
    {
        // public class deptmaster
        //{
        [Key]
        [Required]
        public int deptcode { get; set; }
        [MaxLength(20, ErrorMessage = "Not allowed above 20 chars")]
        [MinLength(2, ErrorMessage = "Not allowed below 2 chars")]
        public string deptname { get; set; }

        // public string City { get; set; }
        //1 Student---M Enrollments
        // public virtual ICollection<empprofile> empprofile { get; set; }
        //  [DataType(DataType.DateTime,ErrorMessage ="not valid date")]


        //public class empprofile
        //{
        [Key]
        public int empcode { get; set; }
        public DateTime dob { get; set; }
        public string empname { get; set; }
        public string email { get; set; }
    }
}
        //public int deptcode { get; set; }

        //[ForeignKey("deptcode")]
        // public virtual deptmaster dcode { get; set; }


        // }}
    
