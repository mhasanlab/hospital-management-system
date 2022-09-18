using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalAPI.Models.Class
{
    public class MedicalTest
    {
        [Key]
        public int MedicalTestCode { get; set; }
        [Required, StringLength(50),Display(Name ="Test Name")]
        public string TestName { get; set; }
        [Required, Display(Name = "Test Price")]
        public decimal TestPrice { get; set; }

        //Nev
        public virtual ICollection<Lab> Labs { get; set; }
        public virtual ICollection<PatientReport> PatientReports { get; set; }
    }
}
