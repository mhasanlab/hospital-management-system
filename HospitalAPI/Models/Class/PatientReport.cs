using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalAPI.Models.Class
{
    public class PatientReport
    {
        [Key]
        public int ReortId { get; set; }
        //Foreign Key
        [Required, ForeignKey("Patient")]
        public int PatientId { get; set; }
        //Foreign Key
        [Required, ForeignKey("MedicalTest")]
        public int MedicalTestCode { get; set; }
        public string Diagnose { get; set; }
        //Foreign Key
        [Required, ForeignKey("Doctor")]
        public int? DoctorId { get; set; }

        // Nev
        public virtual Doctor Doctor { get; set; }
        public virtual MedicalTest MedicalTest { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
