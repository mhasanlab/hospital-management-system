using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalAPI.Models.Class
{
    public class Payroll
    {
        [Key]
        public int PayrollId { get; set; }
        //Foreign Key
        [Required, ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        public decimal BasicSalary { get; set; }
        public decimal BonusSalary { get; set; }
        public decimal Compenstation { get; set; }
        public int AccountNo { get; set; }
        public decimal NetSalary { get; set; }

        //Nev
        public virtual Employee Employee { get; set; }
    }
}
