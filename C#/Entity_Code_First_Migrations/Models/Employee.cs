using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Code_First.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(20)]
        public string Emp_Name {  get; set; }
        [MaxLength(10)]
        public string Gender {  get; set; }
        public int Age { get; set; }
        public double Salary {  get; set; }
        public Department Dep_Id { get; set; }
        public string city { get; set;}
        public string phone { get; set;}
        public string maritial_status {  get; set; }
        public string role {  get; set; }
        public string experience { get; set; }
    }
}
