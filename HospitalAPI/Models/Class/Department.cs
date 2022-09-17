using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalAPI.Models.Class
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        public string DepName { get; set; }
        public string DepManeger { get; set; }

        //Nev
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
