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
        
        [Required, Display(Name ="Salary")]

        public decimal BasicSalary { get; set; }
        [Required, Display(Name ="Bonus Salary")]
        public decimal BonusSalary { get; set; }
        [Required, Display(Name ="Compenstation")]
        public decimal Compenstation { get; set; }
        public int AccountNo { get; set; }
        [Required, Display(Name = "Net Salary")]
        public decimal NetSalary { get; set; }

        //Nev
        public virtual Employee Employee { get; set; }
    }
}
