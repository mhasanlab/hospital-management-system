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
        [Required, StringLength(50)]
        public string DepName { get; set; }
        [Required, StringLength(50)]
        public string DepManeger { get; set; }

        //Nev
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
