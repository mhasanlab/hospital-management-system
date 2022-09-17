using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalAPI.Models.Class
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public int PersonalId { get; set; }
        //Foreign Key
        [Required, ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public DateTime Dob { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        //Nev
        public virtual Department Department { get; set; }
        public virtual ICollection<Payroll> Payrolls { get; set; }
    }
}
