using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalAPI.Models.Class
{
    public class Lab
    {
        [Key]
        public int LabNo { get; set; }
        //Foreign Key
        [Required, ForeignKey("MedicalTest")]
        public int MedicalTestCode { get; set; }
        public DateTime TestDate { get; set; }
        //Foreign Key
        [Required, ForeignKey("Patient")]
        public int PatientId { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public decimal BloodPressure { get; set; }
        public string BloodGroup { get; set; }

        //Nev
        public virtual MedicalTest MedicalTest { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
