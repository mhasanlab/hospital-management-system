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
        [Required, StringLength(50)]
        public string FirstName { get; set; }
        [Required, StringLength(50)]
        public string LastName { get; set; }
        [Required, StringLength(50)]
        public string Country { get; set; }
        [Required, Column(TypeName = "date"), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Dob { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required, StringLength(150)]
        public string Address { get; set; }
        [Required, StringLength(50)]
        public string Phone { get; set; }
        [Required, StringLength(50)]
        public string Email { get; set; }

        //Nev
        public virtual Department Department { get; set; }
        public virtual ICollection<Payroll> Payrolls { get; set; }
    }
}
