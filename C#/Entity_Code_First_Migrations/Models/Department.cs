using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Code_First.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Dep_Name { get; set; }
        public List<Employee> employees { get; set; }
    }
}
